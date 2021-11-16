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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frm_StaffOp frm_StaffOp = new frm_StaffOp();
            frm_StaffOp.Show();
        }

        private void lbl_USWBookings_Click(object sender, EventArgs e)
        {

        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            frm_StudentOp frm_StudentOp = new frm_StudentOp();
            frm_StudentOp.Show();
        }
    }
}
