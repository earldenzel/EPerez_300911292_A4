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
    public partial class AssignClubForm : Form
    {
        Registrant registrant;

        public AssignClubForm()
        {
            InitializeComponent();
        }

        public AssignClubForm(Registrant registrant):this()
        {
            this.registrant = registrant;
        }

        private void AssignClubForm_Load(object sender, EventArgs e)
        {
            cmbClubs.DataSource = ((Form1)Owner).ClubManager.Clubs;
            cmbClubs.DisplayMember = "Name";
        }

        private void btnAssignClub_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            //if ((Club)cmbClubs.SelectedItem != null)
            try
            {
                Club club = (Club)cmbClubs.SelectedItem;
                Coach coach = registrant as Coach;
                if (coach != null)
                {
                    coach.Club = club;
                }
                else
                {
                    registrant.Club = club;
                }
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
