
namespace BookingSystem
{
    partial class frm_StaffMain
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
            this.lbl_StaffMain = new System.Windows.Forms.Label();
            this.btn_EditA = new System.Windows.Forms.Button();
            this.btn_EditB = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Out = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StaffMain
            // 
            this.lbl_StaffMain.AutoSize = true;
            this.lbl_StaffMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffMain.Location = new System.Drawing.Point(129, 52);
            this.lbl_StaffMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StaffMain.Name = "lbl_StaffMain";
            this.lbl_StaffMain.Size = new System.Drawing.Size(263, 39);
            this.lbl_StaffMain.TabIndex = 12;
            this.lbl_StaffMain.Text = "Staff Main Menu";
            // 
            // btn_EditA
            // 
            this.btn_EditA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditA.Location = new System.Drawing.Point(57, 166);
            this.btn_EditA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditA.Name = "btn_EditA";
            this.btn_EditA.Size = new System.Drawing.Size(159, 96);
            this.btn_EditA.TabIndex = 13;
            this.btn_EditA.Text = "Edit Account";
            this.btn_EditA.UseVisualStyleBackColor = true;
            // 
            // btn_EditB
            // 
            this.btn_EditB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditB.Location = new System.Drawing.Point(57, 310);
            this.btn_EditB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditB.Name = "btn_EditB";
            this.btn_EditB.Size = new System.Drawing.Size(159, 96);
            this.btn_EditB.TabIndex = 14;
            this.btn_EditB.Text = "Edit Books";
            this.btn_EditB.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(272, 166);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(215, 96);
            this.btn_Create.TabIndex = 15;
            this.btn_Create.Text = "Create New Account";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.Location = new System.Drawing.Point(272, 310);
            this.btn_Out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(215, 96);
            this.btn_Out.TabIndex = 16;
            this.btn_Out.Text = "Sign Out";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // btn_End
            // 
            this.btn_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_End.Location = new System.Drawing.Point(137, 426);
            this.btn_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(215, 96);
            this.btn_End.TabIndex = 17;
            this.btn_End.Text = "End Program";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // frm_StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 571);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_EditB);
            this.Controls.Add(this.btn_EditA);
            this.Controls.Add(this.lbl_StaffMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_StaffMain";
            this.Text = "frm_StaffMain";
            this.Load += new System.EventHandler(this.frm_StaffMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StaffMain;
        private System.Windows.Forms.Button btn_EditA;
        private System.Windows.Forms.Button btn_EditB;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Button btn_End;
    }
}