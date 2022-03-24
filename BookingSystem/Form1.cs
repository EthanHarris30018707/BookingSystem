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
    public partial class frm_Main : Form, IMessageFilter
    {
        private Timer mTimer;
        private DateTime startTime;
        public frm_Main()
        {
            InitializeComponent();
            
            Application.AddMessageFilter(this);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frm_StaffOp frm_StaffOp = new frm_StaffOp();
            frm_StaffOp.Show();
            this.Hide();
        }

        private void lbl_USWBookings_Click(object sender, EventArgs e)
        {

        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            frm_StudentOp frm_StudentOp = new frm_StudentOp();
            frm_StudentOp.Show();
            this.Hide();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            
            string frmat = @"mm\:ss";
            label2.Text = TimeSpan.FromMinutes(2).ToString(frmat);
            timer1.Interval = 1000;
            startTime = DateTime.Now;
            timer1.Start();


        }

        public bool PreFilterMessage(ref Message m)
        {
            
            bool active = m.Msg == 0x100 || m.Msg == 0x101; 
            active = active || m.Msg == 0x201;
            active = active || m.Msg == 0x10;  
            if (active)
            {
                startTime = DateTime.Now;
                timer1.Start();
            }
            return false;
            
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string frmat = @"mm\:ss";
            label2.Text = (TimeSpan.FromMinutes(2) - (DateTime.Now - startTime)).ToString(frmat);
            label1.Text = "Timer";
            if (label2.Text == "00:00")
            {
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("The system will logout and close automatically. Are you sure?", "Time out", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    startTime = DateTime.Now;
                    timer1.Stop();
                    timer1.Start();
                }
                

            }

        }
        

        
    }
}
