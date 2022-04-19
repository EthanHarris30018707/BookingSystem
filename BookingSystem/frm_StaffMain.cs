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
    public partial class frm_StaffMain : Form
    {
        public frm_StaffMain()
        {
            InitializeComponent();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            //Set the logged on staff to null
            Cookie.Instance.LoggedStaff = null;

            frm_Main frm_Main = new frm_Main();
            frm_Main.Show();            
            this.Close();
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            frm_CreateStaff frm_CreateStaff = new frm_CreateStaff();
            frm_CreateStaff.Show();
            this.Hide();
        }
    }
}
