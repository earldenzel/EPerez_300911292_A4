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
    public partial class AssignSwimmersToEventForm : Form
    {
        SwimMeet swimMeet;
        public AssignSwimmersToEventForm()
        {
            InitializeComponent();
        }

        public AssignSwimmersToEventForm(SwimMeet swimMeet) : this()
        {
            this.swimMeet = swimMeet;
        }


        private void AssignSwimmersToEventForm_Load(object sender, EventArgs e)
        {
            cmbEvent.DataSource = swimMeet.Events;
            cmbEvent.DisplayMember = "Name";
            cmbSwimmer.DataSource = ((Form1)Owner).SwimmerManager.Swimmers;
            cmbSwimmer.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                Event aEvent = (Event)cmbEvent.SelectedItem;
                Swimmer swimmer = (Swimmer)cmbSwimmer.SelectedItem;

                aEvent.AddSwimmer(swimmer);

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
