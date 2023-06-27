using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        Function fn = new Function();
        String query;

        public Form1()
        {
            InitializeComponent();
            txtusername.KeyDown += txtusername_KeyDown;
            panel1.Visible = false; // Initially hide panel1

            this.Load += Form1_Load; // Handle the form load event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = true; // Make label4 visible
            guna2CirclePictureBox1.BringToFront(); // Bring it to the front
            guna2CirclePictureBox1.BackColor = Color.Transparent; // Set the BackColor to Transparent
            guna2PictureBox2.Visible = true; // Make label4 visible
            guna2PictureBox2.BringToFront(); // Bring it to the front
            guna2PictureBox2.BackColor = Color.Transparent; // Set the BackColor to Transparent
            //guna2PictureBox3.Visible = true; // Make label4 visible
            //guna2PictureBox3.BringToFront(); // Bring it to the front
            //guna2PictureBox3.BackColor = Color.Transparent; // Set the BackColor to Transparent
            label4.Visible = true;
            label5.Visible = true;
            txtusername.Focus(); // Set cursor focus on the username textbox
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            query = "select username, pass from employee where username = '" + txtusername.Text + "' and pass = '" + txtpassword.Text + "' ";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelerror.Visible = false;
                dashboard dash = new dashboard();
                this.Hide();
                dash.Show();

                // Set focus on txtroomno control
              //  dash.guna2textbox1.Focus();
            }
            else
            {
                labelerror.Visible = true;
                txtpassword.Clear();
            }
        }


        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound when Enter key is pressed
                if (txtpassword.Focused)
                {
                    btnlogin.PerformClick(); // Simulate a click on the login button
                }
                else
                {
                    txtpassword.Focus(); // Set focus to the password textbox
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                panel1.Visible = true; 
                txtusername.Focus(); 
                guna2CirclePictureBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                
                label5.Visible = false;
                label4.Visible = false;
                return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2CirclePictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpassword.Focused)
                {
                    btnlogin.PerformClick();
                }
                else
                {
                    btnlogin.PerformClick();
                    
                }
            }
        }
    }
}
