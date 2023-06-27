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
    public partial class UserControl2 : UserControl
    {
        Function fn = new Function();
        String query;
        public UserControl2()
        {
            InitializeComponent();
            TXTroomNo.KeyDown += TXTroomNo_KeyDown;
            this.Load += UserControl2_Load;
            // TXTroomNo.Focus();
        }

        private void TXTroomNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound when Enter key is pressed

                if (TXTroomNo.Focused)
                {
                    txtType.Focus();
                }
                else if (txtType.Focused)
                {
                    txtBed.Focus();
                }
                else if (txtBed.Focused)
                {
                    txtPrice.Focus();
                }
                else if (txtPrice.Focused)
                {
                    btnAddroom.PerformClick(); // Simulate a click on the Add Room button
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void UserControl2_Load(object sender, EventArgs e)
        //{

        //    TXTroomNo.Select(0, 0); // Set focus and move the cursor to the beginning of the textbox

        //}
        private void UserControl2_Load(object sender, EventArgs e)
        {
            // Other initialization code...
            query = "SELECT * FROM rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            // TXTroomNo.Focus();
            label2.Visible = true;

            TXTroomNo.Enter += (s, evt) =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    TXTroomNo.Select(0, 0);
                });
            };

            TXTroomNo.Focus();
        }



        private void btnAddroom_Click(object sender, EventArgs e)
        {
            if (TXTroomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = TXTroomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "INSERT INTO rooms (roomNo, roomtype, bed, price) VALUES ('" + roomno + "', '" + type + "', '" + bed + "', '" + price + "')";
                fn.setData(query, "Room Added.");

                UserControl2_Load(this, null);
                clearAll();

                TXTroomNo.Focus(); // Set focus to the room number textbox after adding the room
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            TXTroomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UserControl2_Enter(object sender, EventArgs e)
        {
            UserControl2_Load(this, null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if the clicked cell is within the valid range
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                // Retrieve the values from the selected row and display them in the textboxes and combo boxes
                TXTroomNo.Text = row.Cells["roomNo"].Value.ToString();
                txtType.SelectedItem = row.Cells["roomtype"].Value.ToString();
                txtBed.SelectedItem = row.Cells["bed"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdateed_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (TXTroomNo.Text != "")
            {
                String roomNo = TXTroomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "UPDATE rooms SET roomtype = '" + type + "', bed = '" + bed + "', price = '" + price + "' WHERE roomNo = '" + roomNo + "'";
                fn.setData(query, "Room Updated.");

                UserControl2_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Select a room to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            if (TXTroomNo.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String roomNo = TXTroomNo.Text;
                    query = "DELETE FROM rooms WHERE roomNo = '" + roomNo + "'";
                    fn.setData(query, "Room Deleted.");

                    UserControl2_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXTroomNo.Text))
            {
                string roomNo = TXTroomNo.Text;
                query = "SELECT * FROM rooms WHERE roomNo = '" + roomNo + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    // Retrieve the values from the selected row and display them in the textboxes and combo boxes
                    TXTroomNo.Text = row["roomNo"].ToString();
                    txtType.SelectedItem = row["roomtype"].ToString();
                    txtBed.SelectedItem = row["bed"].ToString();
                    txtPrice.Text = row["price"].ToString();
                }
                else
                {
                    MessageBox.Show("No matching room found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Enter a room number to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTroomNo_Load(object sender, EventArgs e)
        {
            //  TXTroomNo.Focus();
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtType_Leave(object sender, EventArgs e)
        {

        }

        private void txtType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound when Enter key is pressed
                if (txtType.Focused)
                {
                    //btnlogin.PerformClick(); // Simulate a click on the login button
                    txtBed.Focus();
                }

                else if (txtBed.Focused)
                {
                    txtPrice.Focus(); // Set focus to the password textbox
                }
            }




        }

        private void txtBed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound when Enter key is pressed
                if (txtBed.Focused)
                {
                    txtPrice.Focus(); // Set focus to the txtPrice textbox
                    e.Handled = true; // Mark the event as handled to prevent further processing
                }
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPrice.Focused)
                {
                    btnAddroom.PerformClick();
                }
                else
                {
                    btnAddroom.PerformClick();
                }
            }
        }

    }
}