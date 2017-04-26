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
    public partial class AddEventForm : Form
    {
        SwimMeet swimMeet;

        public AddEventForm()
        {
            InitializeComponent();
        }

        public AddEventForm(SwimMeet swimMeet):this()
        {
            this.swimMeet = swimMeet;
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            cmbDistance.DataSource = Enum.GetValues(typeof(EventDistance));
            cmbStroke.DataSource = Enum.GetValues(typeof(Stroke));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                EventDistance eventDistance = (EventDistance)cmbDistance.SelectedValue;
                Stroke stroke = (Stroke)cmbStroke.SelectedValue;

                Event aEvent = new Event(eventDistance, stroke);

                swimMeet.AddEvent(aEvent);
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
