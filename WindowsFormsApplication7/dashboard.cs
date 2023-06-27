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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
      //  public partial class dashboard : Form
     //   {
            // Other code in the dashboard form

        //public void SetFocusOnTxtRoomNo()
        //{
        //    guna2text
        //}
       // }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_CustomerCheckOut1.Visible = true;
            uc_CustomerCheckOut1.BringToFront();
            movingpanel.Left = btncheckout.Left + 18;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uc_Employee1.Visible = true;
            uc_Employee1.BringToFront();
            movingpanel.Left = btnemployee.Left + 18;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            movingpanel.Left = btncustomerdetails.Left + 18;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btncustomerreg.Left+18;
            uccustomer1.Visible = true;
            uccustomer1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnaddroom.Left + 18;
            userControl21.Visible = true;
            userControl21.BringToFront();
        }

        private void btnminimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl21_Load_2(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uc_Employee1.Visible = false;
            userControl21.Visible = false;
            uccustomer1.Visible = false;
            btnaddroom.PerformClick();
        }

        private void uccustomer1_Load(object sender, EventArgs e)
        {

        }

        private void uc_CustomerCheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void btnaddroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnaddroom_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
