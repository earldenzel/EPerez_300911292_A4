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
    public partial class AddSwimmerForm : Form
    {
        Swimmer swimmer;
        public AddSwimmerForm()
        {
            InitializeComponent();
        }
        
        public AddSwimmerForm(Swimmer swimmer):this()
        {
            this.swimmer = swimmer;
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
                swimmer = new Swimmer(name, dob, address, phone);
                DialogResult = DialogResult.OK;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DialogResult == DialogResult.OK)
            {
                ((Form1)Owner).SwimmerManager.Add(swimmer);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
