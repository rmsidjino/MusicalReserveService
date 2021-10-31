using System;
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
    public partial class frmMap : Form
    {
        public string Url { get; set; }
        public frmMap()
        {
            InitializeComponent();
            
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(this.Url);
        }
    }
}
