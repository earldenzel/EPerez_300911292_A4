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
    public partial class AddClubForm : Form
    {
        Club aClub;

        public AddClubForm()
        {
            InitializeComponent();
        }
        
        public AddClubForm(Club aClub):this()
        {
            this.aClub = aClub;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            try
            {
                string name = txtName.Text;
                Address address = new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtZip.Text);
                long phone = Convert.ToInt64(txtPhone.Text);
                if (txtName.Text == "") throw new Exception("Please write a name");
                aClub = new Club(name, address, phone);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (DialogResult == DialogResult.OK)
            {
                ((Form1)Owner).ClubManager.Add(aClub);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
