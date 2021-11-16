
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
            this.SuspendLayout();
            // 
            // btn_EditA
            // 
            this.btn_EditA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditA.Location = new System.Drawing.Point(18, 72);
            this.btn_EditA.Name = "btn_EditA";
            this.btn_EditA.Size = new System.Drawing.Size(119, 78);
            this.btn_EditA.TabIndex = 14;
            this.btn_EditA.Text = "Edit Account";
            this.btn_EditA.UseVisualStyleBackColor = true;
            // 
            // lbl_StudentMain
            // 
            this.lbl_StudentMain.AutoSize = true;
            this.lbl_StudentMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentMain.Location = new System.Drawing.Point(12, 9);
            this.lbl_StudentMain.Name = "lbl_StudentMain";
            this.lbl_StudentMain.Size = new System.Drawing.Size(247, 31);
            this.lbl_StudentMain.TabIndex = 15;
            this.lbl_StudentMain.Text = "Student Main Menu";
            // 
            // btn_Out
            // 
            this.btn_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.Location = new System.Drawing.Point(190, 131);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(161, 78);
            this.btn_Out.TabIndex = 17;
            this.btn_Out.Text = "Sign Out";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Location = new System.Drawing.Point(18, 188);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(119, 78);
            this.btn_Book.TabIndex = 18;
            this.btn_Book.Text = "Books";
            this.btn_Book.UseVisualStyleBackColor = true;
            // 
            // frm_StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 337);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.lbl_StudentMain);
            this.Controls.Add(this.btn_EditA);
            this.Name = "frm_StudentMenu";
            this.Text = "frm_StudentMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditA;
        private System.Windows.Forms.Label lbl_StudentMain;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Button btn_Book;
    }
}