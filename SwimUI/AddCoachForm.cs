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
    public partial class AddCoachForm : Form
    {
        Coach coach;

        public AddCoachForm()
        {
            InitializeComponent();
        }

        public AddCoachForm(Coach coach) : this()
        {
            this.coach = coach;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                Address address = new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtZip.Text);
                string name = txtName.Text;
                DateTime dob = dateTimePickerDOB.Value.Date;
                long phone = Convert.ToInt64(txtPhone.Text);

                if (txtName.Text == "") throw new Exception("Please write a name");
                if (txtCredentials.Text == "") throw new Exception("The coach has to have credentials!");
                coach = new Coach(name, dob, address, phone);
                coach.Credentials = txtCredentials.Text;
                //club.AddCoach(coach);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DialogResult == DialogResult.OK)
            {
                ((Form1)Owner).CoachManager.Add(coach);
                Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
