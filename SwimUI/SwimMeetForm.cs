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
    public partial class SwimMeetForm : Form
    {
        SwimMeet swimMeet;

        public SwimMeetForm()
        {
            InitializeComponent();
        }

        public SwimMeetForm(SwimMeet swimMeet):this()
        {
            this.swimMeet = swimMeet;
        }

        private void SwimMeetForm_Load(object sender, EventArgs e)
        {
            cmbPoolType.DataSource = Enum.GetValues(typeof(PoolType));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                string name = txtName.Text;
                DateTime start = dateTimePickerStart.Value.Date;
                DateTime end = dateTimePickerEnd.Value.Date;
                PoolType poolType = (PoolType)cmbPoolType.SelectedValue;

                if (txtName.Text == "") throw new Exception("Please write a name");
                int lanes = Convert.ToInt32(txtLanes.Text);

                swimMeet = new SwimMeet(name, start, end, poolType, lanes);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DialogResult == DialogResult.OK)
            {
                ((Form1)Owner).SwimMeetManager.Add(swimMeet);
                Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
