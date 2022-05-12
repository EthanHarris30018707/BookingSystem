
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
            this.components = new System.ComponentModel.Container();
            this.btn_Student = new System.Windows.Forms.Button();
            this.lbl_USWBookings = new System.Windows.Forms.Label();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.form1logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.form1logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Student
            // 
            this.btn_Student.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Location = new System.Drawing.Point(483, 285);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(255, 215);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // lbl_USWBookings
            // 
            this.lbl_USWBookings.AutoSize = true;
            this.lbl_USWBookings.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_USWBookings.Location = new System.Drawing.Point(379, 252);
            this.lbl_USWBookings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_USWBookings.Name = "lbl_USWBookings";
            this.lbl_USWBookings.Size = new System.Drawing.Size(0, 31);
            this.lbl_USWBookings.TabIndex = 2;
            this.lbl_USWBookings.Click += new System.EventHandler(this.lbl_USWBookings_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.Location = new System.Drawing.Point(58, 285);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(255, 215);
            this.btn_Staff.TabIndex = 3;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1logo
            // 
            this.form1logo.Image = global::BookingSystem.Properties.Resources.Books_SW_Logo;
            this.form1logo.Location = new System.Drawing.Point(94, 52);
            this.form1logo.Name = "form1logo";
            this.form1logo.Size = new System.Drawing.Size(620, 192);
            this.form1logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.form1logo.TabIndex = 6;
            this.form1logo.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 660);
            this.Controls.Add(this.form1logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.lbl_USWBookings);
            this.Controls.Add(this.btn_Student);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Label lbl_USWBookings;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox form1logo;
    }
}

