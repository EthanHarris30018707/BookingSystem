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
            frm_StudentMenu frm_StudentMenu = new frm_StudentMenu();
            frm_StudentMenu.Show();
            this.Close();
        }
    }
}
