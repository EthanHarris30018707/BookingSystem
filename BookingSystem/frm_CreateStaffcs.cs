﻿using System;
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
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_StaffMain frm_StaffMain = new frm_StaffMain();
            frm_StaffMain.Show();
            this.Close();
        }
    }
}
