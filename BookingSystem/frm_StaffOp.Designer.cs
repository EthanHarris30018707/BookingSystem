
namespace BookingSystem
{
    partial class frm_StaffOp
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_StaffId = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.stafflogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stafflogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(200, 479);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(179, 75);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(194, 330);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(106, 31);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Staff Id";
            // 
            // txt_StaffId
            // 
            this.txt_StaffId.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StaffId.Location = new System.Drawing.Point(338, 326);
            this.txt_StaffId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_StaffId.Name = "txt_StaffId";
            this.txt_StaffId.Size = new System.Drawing.Size(356, 46);
            this.txt_StaffId.TabIndex = 8;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(338, 399);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(356, 46);
            this.txt_Password.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(194, 404);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(116, 31);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Back
            // 
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Back.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(567, 479);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 75);
            this.btn_Back.TabIndex = 60;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // stafflogo
            // 
            this.stafflogo.Image = global::BookingSystem.Properties.Resources.Books_SW_Logo;
            this.stafflogo.Location = new System.Drawing.Point(160, 21);
            this.stafflogo.Name = "stafflogo";
            this.stafflogo.Size = new System.Drawing.Size(602, 198);
            this.stafflogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stafflogo.TabIndex = 61;
            this.stafflogo.TabStop = false;
            this.stafflogo.Click += new System.EventHandler(this.stafflogo_Click);
            // 
            // frm_StaffOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Back;
            this.ClientSize = new System.Drawing.Size(901, 683);
            this.Controls.Add(this.stafflogo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_StaffId);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_StaffOp";
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.frm_StaffOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stafflogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_StaffId;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox stafflogo;
    }
}