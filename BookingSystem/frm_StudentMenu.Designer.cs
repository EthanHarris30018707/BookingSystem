
namespace BookingSystem
{
    partial class frm_StudentMenu
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
            this.btn_EditA = new System.Windows.Forms.Button();
            this.lbl_StudentMain = new System.Windows.Forms.Label();
            this.btn_Out = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.studentmenulogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentmenulogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditA
            // 
            this.btn_EditA.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditA.Location = new System.Drawing.Point(267, 515);
            this.btn_EditA.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_EditA.Name = "btn_EditA";
            this.btn_EditA.Size = new System.Drawing.Size(277, 186);
            this.btn_EditA.TabIndex = 14;
            this.btn_EditA.Text = "Edit Account";
            this.btn_EditA.UseVisualStyleBackColor = true;
            // 
            // lbl_StudentMain
            // 
            this.lbl_StudentMain.AutoSize = true;
            this.lbl_StudentMain.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentMain.Location = new System.Drawing.Point(610, 45);
            this.lbl_StudentMain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StudentMain.Name = "lbl_StudentMain";
            this.lbl_StudentMain.Size = new System.Drawing.Size(243, 31);
            this.lbl_StudentMain.TabIndex = 15;
            this.lbl_StudentMain.Text = "Student Main Menu";
            // 
            // btn_Out
            // 
            this.btn_Out.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.Location = new System.Drawing.Point(573, 847);
            this.btn_Out.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(376, 186);
            this.btn_Out.TabIndex = 17;
            this.btn_Out.Text = "Sign Out";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Location = new System.Drawing.Point(815, 515);
            this.btn_Book.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(277, 186);
            this.btn_Book.TabIndex = 18;
            this.btn_Book.Text = "View Books";
            this.btn_Book.UseVisualStyleBackColor = true;
            // 
            // studentmenulogo
            // 
            this.studentmenulogo.Image = global::BookingSystem.Properties.Resources.Books_SW_Logo;
            this.studentmenulogo.Location = new System.Drawing.Point(339, 130);
            this.studentmenulogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentmenulogo.Name = "studentmenulogo";
            this.studentmenulogo.Size = new System.Drawing.Size(723, 305);
            this.studentmenulogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentmenulogo.TabIndex = 19;
            this.studentmenulogo.TabStop = false;
            // 
            // frm_StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1050);
            this.Controls.Add(this.studentmenulogo);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.lbl_StudentMain);
            this.Controls.Add(this.btn_EditA);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frm_StudentMenu";
            this.Text = "frm_StudentMenu";
            ((System.ComponentModel.ISupportInitialize)(this.studentmenulogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditA;
        private System.Windows.Forms.Label lbl_StudentMain;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.PictureBox studentmenulogo;
    }
}