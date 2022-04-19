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
            frm_StaffMain frm_StaffMain = new frm_StaffMain();
            frm_StaffMain.Show();
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
            int error = ValidateInformation();
            if (error != Constants.NO_ERROR)
            {
                MessageBox.Show($"{error.ErrorToMessage()}. Please correct and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                MessageBox.Show($"{staff} successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"error saving {staff}. Please check the information and try again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
