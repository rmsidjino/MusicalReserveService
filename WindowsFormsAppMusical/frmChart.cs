using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAppMusical
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            List<string> musicalList = new List<string>();

            SeatDAC dac = new SeatDAC();
            DataTable dt = dac.GetMusicalSeatCount();
            dac.Dispose();
            chart1.Series[0].Points.DataBind(dt.Rows, "musicalName", "countNum", "Tooltip=musicalName");
            chart1.Series[0].LegendText = "예매율";

            
        }
    }
}
