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
    public delegate void EventHandler(string message);

    public partial class MusicalControl : UserControl
    {
        Musical curMusical;

        public string UserID { get; set; }

        public Musical MusicalInfo
        {
            get
            {
                return curMusical;
            }
            set
            {
                curMusical = value;
                pictureBox1.ImageLocation = value.MusicalPoster;
                
                lblMusicalName.Text = value.MusicalName;
                lblMusicalName.Left = (this.ClientSize.Width - lblMusicalName.Width) / 2;
                if (DateTime.Parse(value.TicketOpenDay) < DateTime.Now)
                {
                    lblPlayDay.Text = value.MusicalStartDay + " - " + value.MusicalEndDay;
                    lblPlayDay.Left = (this.ClientSize.Width - lblPlayDay.Width) / 2;
                }
                else
                {
                    lblPlayDay.Text = $"티켓오픈 D-{(DateTime.Parse(value.TicketOpenDay) - DateTime.Now).Days.ToString()}";
                    lblPlayDay.Left = (this.ClientSize.Width - lblPlayDay.Width) / 2;
                }


            }
        }
        public MusicalControl()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
                frmMusicalShow frm = new frmMusicalShow();

                frm.MusicalID = this.curMusical.MusicalID;
                frm.UserID = this.UserID;
                frm.ShowDialog();
        }

    }
}
