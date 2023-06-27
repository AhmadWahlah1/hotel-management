using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7.All_User_Control
{
    public partial class uc_CustomerCheckOut : UserControl
    {
        Function fn = new Function();
        String query;
        public uc_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid WHERE customer.chekout = 'NO'";

            DataSet ds = fn.getData(query);
            guna2DataGridView21.DataSource = ds.Tables[0];
            txtname.Focus();
        }

        private void guna2DataGridView21_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView21.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView21.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtnam.Text = guna2DataGridView21.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtroomn.Text = guna2DataGridView21.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }


        private void txtname_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid WHERE cname LIKE '" + txtname.Text + "%' AND chekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView21.DataSource = ds.Tables[0];

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (txtnam.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtcheckout.Text;
                    query = "UPDATE customer SET chekout = 'YES', checkout = '" + cdate + "' WHERE cid = '" + id + "'; UPDATE rooms SET booked = 'NO' WHERE roomNo = '" + txtroomn.Text + "'";
                    fn.setData(query, "Check Out Successful.");
                    uc_CustomerCheckOut_Load(this, null);
                    clearall();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearall()
        {
            txtname.Clear();
            txtnam.Clear();
            txtroomn.Clear();
            txtcheckout.ResetText();
        }

        public int id { get; set; }

        private void uc_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearall();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtname.Focus();
            }
        }

        private void txtcheckout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btncheck.PerformClick();
            }
        }

        private void btncheck_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
