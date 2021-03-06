using BookingSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frm_CreateStaff : Form
    {
        public frm_CreateStaff()
        {
            InitializeComponent();
            txtStaffId.Text = Utility.GeneratedNextStaffId();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            (new frm_StaffMain()).Show();
            this.Close();
        }

        private int ValidateInformation()
        {
            //Phone number should be length of 11 and convertible to int
            if (txtPhone.Text.Length != 11 && !int.TryParse(txtPhone.Text, out _))
            {
                return Constants.INVALID_PHONE_NUMBER_ERROR;
            }
            //Name should be at least length 2
            if (txtName.Text.Length < 2)
            {
                return Constants.INVALID_NAME_ERROR;
            }
            //Staff should be at least 18 years old
            if ((DateTime.Now - dtpDateOfBirth.Value).TotalDays < 18 * 365)
            {
                return Constants.INVALID_DOB_ERROR;
            }
            if (txtPassword.Text != txtPasswordRetype.Text)
            {
                return Constants.PASSWORD_AND_RETYPE_NOT_MATCHING;
            }
            return Constants.NO_ERROR;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //Create the staff
            Staff staff = new Staff()
            {
                StaffId = txtStaffId.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Password = txtPassword.Text.Encrypt(),
                Postcode = txtPostcode.Text                
            };
            if(staff.Save())
            {
                MessageBox.Show($"{staff} account successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new frm_StaffMain()).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"error saving {staff}. Please check the information and try again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            //Enabled the create button if all valid information have been enterered
            int informationCode = ValidateInformation();
            btnCreate.Enabled = informationCode == 0;
            if (informationCode == 0)
            {
                lblInformation.Text = "Information valid";
                lblInformation.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblInformation.Text = informationCode.ErrorToMessage();
                lblInformation.ForeColor = Color.DarkRed;
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }
    }
}
