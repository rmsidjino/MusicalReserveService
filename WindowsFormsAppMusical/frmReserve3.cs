using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMusical
{
    
    public partial class frmReserve3 : Form
    {
        Dictionary<string, DataTable> GradeView = new Dictionary<string, DataTable>();
        public DataTable dtSeat { get; set; }
        DataTable dtDiscount;
        DataTable dt;
        DataTable CommonSeat;
        Hashtable tNum = new Hashtable();
        List<string[]> Ldiscount = new List<string[]>();
        public string UserID { get; set; }
        public int Price { get; set; }
        public int MusicalTimeID { get; set; }
        int totTicket;
        private Form frmReserve2;
        public frmReserve3(Form frmReserve2)
        {
            InitializeComponent();
            this.frmReserve2 = frmReserve2;
            frmReserve2.Hide();
        }

        private void frmReserve3_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("예스 고딕 레귤러",10);


            CommonDAC dac = new CommonDAC();
            DataTable dt = dac.GetCommonCodes("discount");



            dtDiscount = new DataTable();
            dtDiscount.Columns.Add(new DataColumn("Discount", typeof(string)));
            dtDiscount.Columns.Add(new DataColumn("Drate", typeof(int)));
            dtDiscount.Columns.Add(new DataColumn("Tqty", typeof(int)));
            dataGridView1.RowHeadersVisible = false;
            DataGridViewUtil.SetInitGridView(dataGridView1);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "할인유형", "Discount", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "할인율", "Drate", DataGridViewContentAlignment.MiddleRight, colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "개수", "Tqty", DataGridViewContentAlignment.MiddleRight, colWidth: 100);

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            
            btn1.Text = "추가";
            btn1.Width = 50;
            btn1.UseColumnTextForButtonValue = true;
            btn1.Name = "Edit";
            addBtnColumnIdx = dataGridView1.Columns.Add(btn1);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Text = "뺴기";
            btn2.Width = 50;
            btn2.UseColumnTextForButtonValue = true;
            btn2.Name = "Del";
            minusBtnColumnIdx = dataGridView1.Columns.Add(btn2);

            // 그리드뷰 셀클릭 이벤트 핸들러 설정  
            // - 버튼 자체에 이벤트를 설정할 수는 없다.  
            // - 왜냐하면 실제로는 버튼이 아니기 때문이다.  
            // - 버튼 모양을 하고 있는 셀이다.  
            dataGridView1.CellClick += dataGridView1_CellClick;
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dtDiscount.NewRow();
                row["Discount"] = dt.Rows[i]["Name"].ToString();
                row["Drate"] = dt.Rows[i]["Value"];
                row["Tqty"] = 0;
                dtDiscount.Rows.Add(row);
            }
            dtDiscount.DefaultView.Sort = "Drate DESC";
            dtDiscount.AcceptChanges();

            dataGridView1.DataSource = dtDiscount;
            DiscountByGrade();


            CommonDAC com = new CommonDAC();
            CommonSeat = com.GetCommonCodes("seat");
            CommonSeat.PrimaryKey = new DataColumn[] {CommonSeat.Columns["Code"] };
        }

        int addBtnColumnIdx;
        int minusBtnColumnIdx;

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 버튼 클릭 이벤트 설정  
            // - 그리드뷰를 클릭했을 때, 버튼 컬럼 인덱스와 같으면 처리를 한다.  
            // - 이런식으로 버튼 클릭 이벤트를 흉내낸다.  
            int total = 0;
            foreach (Control c in panel1.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton r = (RadioButton)c;
                    if (r.Checked)
                    {
                        if (GradeView.TryGetValue(r.Text, out DataTable value))
                            dt = value;
                    }
                }
            }

            //loop through the datagrid and sum the column 
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dt.Rows[i]["Tqty"]);
                }

                if (e.ColumnIndex == addBtnColumnIdx)
                {
                    if (total >= Convert.ToInt32(txtTotTicket.Text))
                        MessageBox.Show("최대 수량을 넘겼습니다.");
                    else
                        dt.Rows[e.RowIndex]["Tqty"] = Convert.ToInt32(dt.Rows[e.RowIndex]["Tqty"]) + 1;
                }

                if (e.ColumnIndex == minusBtnColumnIdx)
                {
                    if (Convert.ToInt32(dt.Rows[e.RowIndex]["Tqty"]) <= 0)
                    {
                        return;
                    }
                    else
                        dt.Rows[e.RowIndex]["Tqty"] = Convert.ToInt32(dt.Rows[e.RowIndex]["Tqty"]) - 1;
                }
                dt.AcceptChanges();
                dataGridView1.DataSource = dt;
            }
        }


        private void DiscountByGrade()
        {
            List<string> Lgrade = new List<string>() { "VIP", "R", "S", "A" };

            int i = 1;
            foreach(string grade in Lgrade)
            {
                DataRow[] rows = dtSeat.Select($"Sgrade='{grade}'");
                if (rows.Length > 0)
                {
                    tNum.Add(grade, rows.Length);
                    RadioButton rdo = new RadioButton();
                    rdo.Text = grade;
                    rdo.Width = 30;
                    rdo.Location = new Point(lblGrade.Location.X + 60 *i, lblGrade.Location.Y - 5);
                    rdo.Click += Rdo_Click;
                    rdo.Font = new Font("예스 고딕 레귤러", 9);
                    panel1.Controls.Add(rdo);
                    i++;
                }
            }


        }

        private void Rdo_Click(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (!GradeView.TryGetValue(rdo.Text, out DataTable value))
            {
                DataTable dt = dtDiscount.Copy();
                GradeView.Add(rdo.Text, dt);
                dataGridView1.DataSource = dt;
            }
            else
                dataGridView1.DataSource = value;
            txtTotTicket.Text = tNum[rdo.Text].ToString();             
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            totTicket = 0;
            totTicket = CaculatePrice("VIP", dtSeat, totTicket);
            totTicket = CaculatePrice("R", dtSeat, totTicket);
            totTicket = CaculatePrice("S", dtSeat, totTicket);
            totTicket = CaculatePrice("A", dtSeat, totTicket);

            txtTotPrice.Text = totTicket.ToString();

        }

        private int CaculatePrice(string grade, DataTable dtSeat, int tot)
        {
            DataTable value;
            if (GradeView.TryGetValue(grade, out value))
            {
                DataRow row = CommonSeat.Rows.Find(grade);
                for (int i = 0; i < value.Rows.Count; i++)
                {
                    tot += (100 - Convert.ToInt32(value.Rows[i]["Drate"]))* Price * Convert.ToInt32(value.Rows[i]["Tqty"]) / 100 * Convert.ToInt32(row["value"]) / 100;
                    if (Convert.ToInt32(value.Rows[i]["Tqty"]) > 0)
                    {
                        for(int j =0; j< Convert.ToInt32(value.Rows[i]["Tqty"]); j++) 
                        {
                            string[] dInfo = new string[] { value.Rows[i]["Drate"].ToString(), value.Rows[i]["Discount"].ToString() };
                            Ldiscount.Add(dInfo);
                        }                   
                        
                    }
                }

            }

            return tot;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            SeatDAC seat = new SeatDAC();
            bool bResult = seat.Insert(UserID,MusicalTimeID, dtSeat,  Ldiscount);
            if (bResult)
            {
                this.Close();
                MessageBox.Show("예약이 완료되었습니다.");
            }
            else
            {
                this.Close();
                MessageBox.Show("예약을 실패했습니다. 다시 예약해주세요");
            }
            frmReserve2.Close();

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReserve2.Show();
        }
    }
}
