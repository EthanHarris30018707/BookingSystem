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
            if (txt_Name.Text == "Admin")
            {
                if (txt_Password.Text == "Admin")
                {
                    new frm_StudentMenu().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error; Please enter the correct Information");

                }

            }
            else
            {
                MessageBox.Show("Error;Please enter the correct Information");
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
