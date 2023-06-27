using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7.All_User_Control
{
    public partial class uccustomer : UserControl
    {
        private Function fn;
        private int rid;

        public uccustomer()
        {
            InitializeComponent();
            fn = new Function();
            this.Load += uccustomer_Load;
            txtNAME.KeyDown += txtNAME_KeyDown;
        }

        private void uccustomer_Load(object sender, EventArgs e)
        {
            label4.Click += label4_Click;
            txtNAME.TextChanged += guna2TextBox2_TextChanged;
            txtNAME.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void setcombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForcombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomno.Items.Clear();
            txtprice.Clear();
            string query = "select roomNo from rooms where bed = '" + txtbed.Text + "' and roomtype = '" + txtroomtype.Text + "' and booked= 'NO'";
            setcombobox(query, txtroomno);
        }

        private void txtbed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomtype.SelectedIndex = -1;
            txtroomno.Items.Clear();
            txtprice.Clear();
        }

        private void txtroomno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select price, roomid from rooms where roomNo = '" + txtroomno.Text + "'";
            DataSet ds = fn.getData(query);
            txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAlloateroom_Click(object sender, EventArgs e)
        {
            if (txtNAME.Text != "" && txtnationality.Text != "" && txtgender.Text != "" && txtdob.Text != "" && txtidproof.Text != "" && txtaddress.Text != "" && txtcheckin.Text != "" && txtprice.Text != "")
            {
                string name = txtNAME.Text;
                Int64 mobile = Int64.Parse(txtcontact.Text);
                string national = txtnationality.Text;
                string gender = txtgender.Text;
                string dob = txtdob.Text;
                string idproof = txtidproof.Text;
                string address = txtaddress.Text;
                string checkin = txtcheckin.Text;

                string query = "INSERT INTO customer(cname, mobile, nationality, gender, dob, idproof, addres, checkin, roomid, empid, ceid) " +
                    "VALUES ('" + name + "', '" + mobile + "', '" + national + "', '" + gender + "', '" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "', '" + rid + "', 1, NULL);" +
                    "UPDATE rooms SET booked='YES' WHERE roomNo= '" + txtroomno.Text + "' ";

                fn.setData(query, "Room No " + txtroomno.Text + " Allocation Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("All fields are mandatory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtNAME.Clear();
            txtcontact.Clear();
            txtnationality.Clear();
            txtgender.SelectedIndex = -1;
            txtdob.ResetText();
            txtidproof.Clear();
            txtaddress.Clear();
            txtcheckin.ResetText();
            txtbed.SelectedIndex = -1;
            txtroomtype.SelectedIndex = -1;
            txtroomno.Items.Clear();
            txtprice.Clear();
        }

        private void uccustomer_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtNAME_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtNAME.Focused)
                {
                    txtcontact.Focus();
                }
                else
                {
                    txtcontact.Focus();
                }
            }
        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtcontact.Focused)
                {
                    txtnationality.Focus();
                }
                else
                {
                    txtnationality.Focus();
                }
            }
        }

        private void txtnationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtnationality.Focused)
                {
                    txtgender.Focus();
                }
                else if (txtgender.Focused)
                {
                    txtdob.Focus();
                }
            }
        }

        private void txtdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdob.Focused)
                {
                    txtidproof.Focus();
                }
                else
                {
                    txtidproof.Focus();
                }
            }
        }

        private void txtidproof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtidproof.Focused)
                {
                    txtaddress.Focus();
                }
                else
                {
                    txtcheckin.Focus();
                }
            }
        }

        private void txtcheckin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcheckin.Focused)
                {
                    txtbed.Focus();
                }
                else
                {
                    txtbed.Focus();
                }
            }
        }

        private void uccustomer_Load_1(object sender, EventArgs e)
        {
            txtNAME.Focus();
        }

        private void txtbed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbed.Focused)
                {
                    txtroomtype.Focus();
                }
                else
                {
                    txtroomtype.Focus();
                }
            }
        }

        private void txtroomtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtroomtype.Focused)
                {
                    txtroomno.Focus();
                }
                else
                {
                    txtroomno.Focus();
                }
            }
        }

        private void txtroomno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtroomno.Focused)
                {
                    txtprice.Focus();
                }
                else
                {
                    txtprice.Focus();
                }
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtprice.Focused)
                {
                    btnAlloateroom.PerformClick();
                }
                else
                {
                    btnAlloateroom.PerformClick();

                }
            }
        }
    }
}
