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
    public partial class frmActorAdd : Form
    {
        DataRowView CastedActor;
        private IList<string> _Actors = new List<string>();
        public IList<string> Actors
        {
            get { return _Actors; }
            set { _Actors = value; }
        }
        public frmActorAdd()
        {
            InitializeComponent();
            ActorDAC aDac = new ActorDAC();
            DataTable dtActor = aDac.GetActor();

            ((ListBox)checkedListBox1).DataSource = dtActor;
            ((ListBox)checkedListBox1).DisplayMember = "actorName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                CastedActor = itemChecked as DataRowView;
                string actorName = CastedActor["actorName"].ToString();
                string actorId = CastedActor["actorID"].ToString();
                Actors.Add(actorId);
            }

            this.Close();
        }
    }
}
