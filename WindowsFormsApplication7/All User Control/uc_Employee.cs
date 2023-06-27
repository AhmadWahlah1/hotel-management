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
    public partial class uc_Employee : UserControl
    {
        Function fn = new Function();
        String query;
        public uc_Employee()
        {
            InitializeComponent();
        }

        private void uc_Employee_Load(object sender, EventArgs e)
        {
            getmaxid();
            txtnname.Focus();
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtnname.Text != "" && txtmobile.Text != "" && txtgenderr.Text != "" && txtemail.Text != "" && txtusername.Text != "" && txtpass.Text != "")
            {
                String name = txtnname.Text;
                Int64 mobile = Int64.Parse(txtmobile.Text);
                String gender = txtgenderr.Text;
                String email = txtemail.Text;
                String username = txtusername.Text;
                String pass = txtpass.Text;

                query = "insert into employee (cname,mobile,gender,emailid,username,pass) values('"+name+"','"+mobile+"','"+gender+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Employee Registered.");
                clearALL();
                getmaxid();
            }
            else
            {
                MessageBox.Show("Fill all Fields. ", "Warning. . .!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //************************************************REQUIRED METHOD************************************
        public void getmaxid()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labeltoSet.Text = (num + 1).ToString();
            }
        }

        public void clearALL()
        {
            txtnname.Clear();
            txtmobile.Clear();
            txtgenderr.SelectedIndex = -1;
            txtemail.Clear();
            txtusername.Clear();
            txtpass.Clear();
        }

        private void labeltoSet_Click(object sender, EventArgs e)
        {

        }
        public void setemployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridViewdetails.DataSource = ds.Tables[0];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridViewdelete.DataSource = ds.Tables[0];
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Comfirmation. . .!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Record Deleted.");
                    tabControl1_SelectedIndexChanged(this, null);
                }
            }
        }

        private void uc_Employee_Leave(object sender, EventArgs e)
        {
            clearALL();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtnname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtnname.Focused)
                {
                    txtmobile.Focus();
                }
                else
                {
                    txtmobile.Focus();
                }
            }
        }

        private void txtmobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtmobile.Focused)
                {
                    txtgenderr.Focus();
                }
                else
                {
                    txtgenderr.Focus();
                }
            }
        }

        private void txtgenderr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtgenderr.Focused)
                {
                    txtemail.Focus();
                }
                else
                {
                    txtemail.Focus();
                }
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtemail.Focused)
                {
                    txtusername.Focus();
                }
                else
                {
                    txtusername.Focus();
                }
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtusername.Focused)
                {
                    txtpass.Focus();
                }
                else
                {
                    txtpass.Focus();
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtpass.Focused)
                {
                    btnregister.PerformClick();
                    txtID.Focus();
                }
                else
                {
                    btnregister.PerformClick();
                    txtID.Focus();
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtID.Focused)
                {
                    btndelete.PerformClick();
                }
                else
                {
                    btndelete.PerformClick();
                }
            }
        }

        
    }
}
