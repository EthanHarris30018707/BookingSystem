using BookingSystem.Database;
using BookingSystem.Logon;
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
    public partial class frm_StaffOp : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public frm_StaffOp()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Get the staff with the enterred username
            Staff enteredStaff = Staff.Staffs.Where((s) => s.StaffId == txt_StaffId.Text).FirstOrDefault();
            if(enteredStaff == null)
            {
                MessageBox.Show("Staff with enterred ID does not exist. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txt_Password.Text.Encrypt() == enteredStaff.Password)
            {
                //Correct credentials enterred
                Cookie.Instance.LoggedStaff = enteredStaff;
                (new frm_StaffMain()).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username and/or password enterred. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main frm_Main = new frm_Main();
            frm_Main.Show();
            this.Close();
        }

        private void frm_StaffOp_Load(object sender, EventArgs e)
        {

        }
    }
}
