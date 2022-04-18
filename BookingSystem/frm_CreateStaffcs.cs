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

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (this.Validate() & passwordTextBox.Text == reTypePasswordTextbox.Text)
            {
                passwordTextBox.Text = Utility.EncryptDecrypt(passwordTextBox.Text);
                reTypePasswordTextbox.Text = Utility.EncryptDecrypt(passwordTextBox.Text);
                this.staffBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);
            }
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void staffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frm_CreateStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.database1DataSet.Staff);

        }

        private void staffBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            string newID = staffDataGridView.Rows.Count.ToString();
            while(newID.Length <10)
            {
                newID = "0" + newID;
            }
            staffDataGridView.Rows[staffDataGridView.Rows.Count - 1].Cells[0].Value = newID;
            staffDataGridView.Refresh();
        }

    }
}
