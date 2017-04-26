using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimLib;

namespace SwimUI
{
    public partial class AssignCoachForm : Form
    {
        Swimmer swimmer;
        public AssignCoachForm()
        {
            InitializeComponent();
        }

        public AssignCoachForm(Swimmer swimmer):this()
        {
            this.swimmer = swimmer;
        }

        private void AssignCoachForm_Load(object sender, EventArgs e)
        {
            cmbCoaches.DataSource = ((Form1)Owner).CoachManager;
            cmbCoaches.DisplayMember = "Name";
        }

        private void btnAssignCoach_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                Coach coach = (Coach)cmbCoaches.SelectedItem;
                coach.AddSwimmer(swimmer); // this code is different from uploaded
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
