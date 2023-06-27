namespace WindowsFormsApplication7
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.movingpanel = new System.Windows.Forms.Panel();
            this.btnemployee = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomerdetails = new Guna.UI2.WinForms.Guna2Button();
            this.btncheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomerreg = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddroom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_Employee1 = new WindowsFormsApplication7.All_User_Control.uc_Employee();
            this.customerDetails1 = new WindowsFormsApplication7.All_User_Control.CustomerDetails();
            this.uc_CustomerCheckOut1 = new WindowsFormsApplication7.All_User_Control.uc_CustomerCheckOut();
            this.uccustomer1 = new WindowsFormsApplication7.All_User_Control.uccustomer();
            this.userControl21 = new WindowsFormsApplication7.All_User_Control.UserControl2();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnminimaize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.movingpanel);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btncustomerdetails);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btncustomerreg);
            this.panel1.Controls.Add(this.btnaddroom);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 130);
            this.panel1.TabIndex = 0;
            // 
            // movingpanel
            // 
            this.movingpanel.BackColor = System.Drawing.Color.Aqua;
            this.movingpanel.Location = new System.Drawing.Point(34, 109);
            this.movingpanel.Name = "movingpanel";
            this.movingpanel.Size = new System.Drawing.Size(308, 5);
            this.movingpanel.TabIndex = 0;
            // 
            // btnemployee
            // 
            this.btnemployee.BorderRadius = 26;
            this.btnemployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnemployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnemployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnemployee.CheckedState.Parent = this.btnemployee;
            this.btnemployee.CustomImages.Parent = this.btnemployee;
            this.btnemployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnemployee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.ForeColor = System.Drawing.Color.White;
            this.btnemployee.HoverState.Parent = this.btnemployee;
            this.btnemployee.Image = ((System.Drawing.Image)(resources.GetObject("btnemployee.Image")));
            this.btnemployee.ImageSize = new System.Drawing.Size(50, 50);
            this.btnemployee.Location = new System.Drawing.Point(1526, 23);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.ShadowDecoration.Parent = this.btnemployee;
            this.btnemployee.Size = new System.Drawing.Size(358, 85);
            this.btnemployee.TabIndex = 4;
            this.btnemployee.Text = "Employee";
            this.btnemployee.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btncustomerdetails
            // 
            this.btncustomerdetails.BorderRadius = 26;
            this.btncustomerdetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomerdetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncustomerdetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btncustomerdetails.CheckedState.Parent = this.btncustomerdetails;
            this.btncustomerdetails.CustomImages.Parent = this.btncustomerdetails;
            this.btncustomerdetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncustomerdetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btncustomerdetails.ForeColor = System.Drawing.Color.White;
            this.btncustomerdetails.HoverState.Parent = this.btncustomerdetails;
            this.btncustomerdetails.Image = ((System.Drawing.Image)(resources.GetObject("btncustomerdetails.Image")));
            this.btncustomerdetails.ImageSize = new System.Drawing.Size(35, 35);
            this.btncustomerdetails.Location = new System.Drawing.Point(1149, 23);
            this.btncustomerdetails.Name = "btncustomerdetails";
            this.btncustomerdetails.ShadowDecoration.Parent = this.btncustomerdetails;
            this.btncustomerdetails.Size = new System.Drawing.Size(358, 85);
            this.btncustomerdetails.TabIndex = 3;
            this.btncustomerdetails.Text = "Customer Details";
            this.btncustomerdetails.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BorderRadius = 26;
            this.btncheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncheckout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btncheckout.CheckedState.Parent = this.btncheckout;
            this.btncheckout.CustomImages.Parent = this.btncheckout;
            this.btncheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncheckout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.HoverState.Parent = this.btncheckout;
            this.btncheckout.Image = ((System.Drawing.Image)(resources.GetObject("btncheckout.Image")));
            this.btncheckout.ImageSize = new System.Drawing.Size(50, 50);
            this.btncheckout.Location = new System.Drawing.Point(772, 23);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.ShadowDecoration.Parent = this.btncheckout;
            this.btncheckout.Size = new System.Drawing.Size(358, 85);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "Check Out";
            this.btncheckout.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btncustomerreg
            // 
            this.btncustomerreg.BorderRadius = 26;
            this.btncustomerreg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomerreg.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncustomerreg.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btncustomerreg.CheckedState.Parent = this.btncustomerreg;
            this.btncustomerreg.CustomImages.Parent = this.btncustomerreg;
            this.btncustomerreg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncustomerreg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerreg.ForeColor = System.Drawing.Color.White;
            this.btncustomerreg.HoverState.Parent = this.btncustomerreg;
            this.btncustomerreg.Image = ((System.Drawing.Image)(resources.GetObject("btncustomerreg.Image")));
            this.btncustomerreg.ImageSize = new System.Drawing.Size(35, 35);
            this.btncustomerreg.Location = new System.Drawing.Point(394, 23);
            this.btncustomerreg.Name = "btncustomerreg";
            this.btncustomerreg.ShadowDecoration.Parent = this.btncustomerreg;
            this.btncustomerreg.Size = new System.Drawing.Size(358, 85);
            this.btncustomerreg.TabIndex = 1;
            this.btncustomerreg.Text = "Customer";
            this.btncustomerreg.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnaddroom
            // 
            this.btnaddroom.BorderRadius = 26;
            this.btnaddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnaddroom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnaddroom.CheckedState.Parent = this.btnaddroom;
            this.btnaddroom.CustomImages.Parent = this.btnaddroom;
            this.btnaddroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnaddroom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddroom.ForeColor = System.Drawing.Color.White;
            this.btnaddroom.HoverState.Parent = this.btnaddroom;
            this.btnaddroom.Image = ((System.Drawing.Image)(resources.GetObject("btnaddroom.Image")));
            this.btnaddroom.ImageSize = new System.Drawing.Size(35, 35);
            this.btnaddroom.Location = new System.Drawing.Point(17, 23);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.ShadowDecoration.Parent = this.btnaddroom;
            this.btnaddroom.Size = new System.Drawing.Size(358, 85);
            this.btnaddroom.TabIndex = 0;
            this.btnaddroom.Text = "Room";
            this.btnaddroom.Click += new System.EventHandler(this.guna2Button1_Click);
            this.btnaddroom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnaddroom_KeyDown);
            this.btnaddroom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnaddroom_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_Employee1);
            this.panel2.Controls.Add(this.customerDetails1);
            this.panel2.Controls.Add(this.uc_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uccustomer1);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Location = new System.Drawing.Point(13, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1986, 942);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uc_Employee1
            // 
            this.uc_Employee1.BackColor = System.Drawing.Color.White;
            this.uc_Employee1.Location = new System.Drawing.Point(15, 14);
            this.uc_Employee1.Name = "uc_Employee1";
            this.uc_Employee1.Size = new System.Drawing.Size(2247, 1668);
            this.uc_Employee1.TabIndex = 4;
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.White;
            this.customerDetails1.Location = new System.Drawing.Point(15, 14);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(2247, 1668);
            this.customerDetails1.TabIndex = 3;
            // 
            // uc_CustomerCheckOut1
            // 
            this.uc_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
          ///  this.uc_CustomerCheckOut1.id = 0;
            this.uc_CustomerCheckOut1.Location = new System.Drawing.Point(15, 14);
            this.uc_CustomerCheckOut1.Name = "uc_CustomerCheckOut1";
            this.uc_CustomerCheckOut1.Size = new System.Drawing.Size(2247, 1668);
            this.uc_CustomerCheckOut1.TabIndex = 2;
            this.uc_CustomerCheckOut1.Load += new System.EventHandler(this.uc_CustomerCheckOut1_Load);
            // 
            // uccustomer1
            // 
            this.uccustomer1.BackColor = System.Drawing.Color.White;
            this.uccustomer1.Location = new System.Drawing.Point(15, 14);
            this.uccustomer1.Name = "uccustomer1";
            this.uccustomer1.Size = new System.Drawing.Size(2247, 1668);
            this.uccustomer1.TabIndex = 1;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.Control;
            this.userControl21.Location = new System.Drawing.Point(15, 14);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(2379, 1668);
            this.userControl21.TabIndex = 0;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load_2);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(32, 32);
            this.btnExit.Location = new System.Drawing.Point(13, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(42, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnminimaize
            // 
            this.btnminimaize.CheckedState.Parent = this.btnminimaize;
            this.btnminimaize.CustomImages.Parent = this.btnminimaize;
            this.btnminimaize.FillColor = System.Drawing.Color.Empty;
            this.btnminimaize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimaize.ForeColor = System.Drawing.Color.Black;
            this.btnminimaize.HoverState.Parent = this.btnminimaize;
            this.btnminimaize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimaize.Image")));
            this.btnminimaize.ImageSize = new System.Drawing.Size(40, 40);
            this.btnminimaize.Location = new System.Drawing.Point(13, 50);
            this.btnminimaize.Name = "btnminimaize";
            this.btnminimaize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnminimaize.ShadowDecoration.Parent = this.btnminimaize;
            this.btnminimaize.Size = new System.Drawing.Size(42, 31);
            this.btnminimaize.TabIndex = 1;
            this.btnminimaize.Click += new System.EventHandler(this.btnminimaize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.btnminimaize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnminimaize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnaddroom;
        private Guna.UI2.WinForms.Guna2Button btnemployee;
        private Guna.UI2.WinForms.Guna2Button btncustomerdetails;
        private Guna.UI2.WinForms.Guna2Button btncheckout;
        private Guna.UI2.WinForms.Guna2Button btncustomerreg;
        private System.Windows.Forms.Panel movingpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UserControl2 userControl21;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.uccustomer uccustomer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.uc_CustomerCheckOut uc_CustomerCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.uc_Employee uc_Employee1;
    }
}