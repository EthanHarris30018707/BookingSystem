
namespace BookingSystem
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Student = new System.Windows.Forms.Button();
            this.lbl_USWBookings = new System.Windows.Forms.Label();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Student
            // 
            this.btn_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Location = new System.Drawing.Point(322, 164);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(170, 140);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // lbl_USWBookings
            // 
            this.lbl_USWBookings.AutoSize = true;
            this.lbl_USWBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_USWBookings.Location = new System.Drawing.Point(161, 53);
            this.lbl_USWBookings.Name = "lbl_USWBookings";
            this.lbl_USWBookings.Size = new System.Drawing.Size(196, 31);
            this.lbl_USWBookings.TabIndex = 2;
            this.lbl_USWBookings.Text = "USW Bookings";
            this.lbl_USWBookings.Click += new System.EventHandler(this.lbl_USWBookings_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.Location = new System.Drawing.Point(37, 164);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(170, 140);
            this.btn_Staff.TabIndex = 3;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 429);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.lbl_USWBookings);
            this.Controls.Add(this.btn_Student);
            this.Name = "frm_Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Label lbl_USWBookings;
        private System.Windows.Forms.Button btn_Staff;
    }
}

