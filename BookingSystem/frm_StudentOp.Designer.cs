
namespace BookingSystem
{
    partial class frm_StudentOp
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.studentaccountlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentaccountlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(299, 362);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(395, 35);
            this.txtPassword.TabIndex = 16;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(69, 368);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 31);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Password";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.Location = new System.Drawing.Point(299, 288);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(395, 35);
            this.txtStudentNumber.TabIndex = 14;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(69, 294);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(206, 31);
            this.lblStudentNumber.TabIndex = 13;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(48, 482);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(199, 75);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(299, 482);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(290, 75);
            this.btn_Create.TabIndex = 17;
            this.btn_Create.Text = "Create Account";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Back.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(661, 482);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(141, 75);
            this.btn_Back.TabIndex = 60;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // studentaccountlogo
            // 
            this.studentaccountlogo.Image = global::BookingSystem.Properties.Resources.Books_SW_Logo;
            this.studentaccountlogo.Location = new System.Drawing.Point(204, 39);
            this.studentaccountlogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentaccountlogo.Name = "studentaccountlogo";
            this.studentaccountlogo.Size = new System.Drawing.Size(566, 213);
            this.studentaccountlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentaccountlogo.TabIndex = 61;
            this.studentaccountlogo.TabStop = false;
            // 
            // frm_StudentOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Back;
            this.ClientSize = new System.Drawing.Size(1029, 677);
            this.Controls.Add(this.studentaccountlogo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.btn_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_StudentOp";
            this.Text = "Student Account Menu";
            this.Load += new System.EventHandler(this.frm_StudentOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentaccountlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox studentaccountlogo;
    }
}