using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace WindowsFormsAppMusical
{
    public partial class frmReserveInfo : Form
    {
        public frmReserveInfo()
        {
            InitializeComponent();
        }

        private void frmReserveInfo_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "예매현황";
            treeView1.Nodes.Add(rootNode);

            SeatDAC dac = new SeatDAC();
            DataSet ds = dac.GetAllSeatInfo();
            dac.Dispose();
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = dr["MusicalName"].ToString();
                node.Name = dr["MusicalID"].ToString();
                node.Tag = dr["MusicalID"].ToString();

                treeView1.Nodes[0].Nodes.Add(node);
                foreach (DataRow dr1 in ds.Tables[1].Rows)
                {
                    TreeNode c_node = new TreeNode();
                    if (node.Name == dr1["MusicalID"].ToString())
                    {
                        c_node.Text = dr1["MusicalDay"].ToString() +"/" +dr1["MusicalTime"].ToString();
                        c_node.Name = dr1["MusicalTimeID"].ToString();
                        c_node.Tag = dr1["MusicalTimeID"].ToString();
                        node.Nodes.Add(c_node);
                    }
                    
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;

            SeatDAC dac = new SeatDAC();
            System.Data.DataTable dt = null;
            if (e.Node.Level == 2)
            {
                dt = dac.GetAllSeatInfo(Convert.ToInt32(e.Node.Name));
            }
            dac.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                System.Data.DataTable dt = (System.Data.DataTable)dataGridView1.DataSource;

                //컬럼헤더를 출력
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    xlWorkSheet.Cells[1, c + 1] = dt.Columns[c].ColumnName;
                }

                //데이터를 출력
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        xlWorkSheet.Cells[r + 2, c + 1] = dt.Rows[r][c].ToString();
                    }
                }

                xlWorkBook.SaveAs(dlg.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("엑셀다운로드 완료");
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dtChanges;
            System.Data.DataTable dtFirst = (System.Data.DataTable)dataGridView1.DataSource;

            dtChanges = dtFirst.GetChanges(DataRowState.Modified);
            if (dtChanges != null)
            {
                SeatDAC dac = new SeatDAC();
                bool bResult = dac.Update(dtChanges);
                dac.Dispose();
                if (bResult)
                {
                    MessageBox.Show("업데이트가 성공적으로 완료되었습니다");
                }
                else
                {
                    MessageBox.Show("업데이트 실패");
                }
            }

        }
    }
}
