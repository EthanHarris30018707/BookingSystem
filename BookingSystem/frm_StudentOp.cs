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
    public partial class frm_StudentOp : Form
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
        public frm_StudentOp()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            frm_CreateStudent frm_CreateStudent = new frm_CreateStudent();
            frm_CreateStudent.Show();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Get the staff with the enterred username
            Student enteredStudent = Student.Students.Where((s) => s.StudentNumber == txtStudentNumber.Text).FirstOrDefault();
            if (enteredStudent == null)
            {
                MessageBox.Show("Student with enterred number does not exist. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Encrypt() == enteredStudent.Password)
            {
                //Correct credentials enterred. Save logon information in cookie
                Cookie.Instance.LoggedStudent = enteredStudent;

                (new frm_StudentMenu()).Show();
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

        private void frm_StudentOp_Load(object sender, EventArgs e)
        {

        }
    }
}
