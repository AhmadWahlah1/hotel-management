namespace WindowsFormsApplication7.All_User_Control
{
    partial class uccustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uccustomer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNAME = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcontact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtcheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidproof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtroomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtroomno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAlloateroom = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nationality";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth";
            // 
            // txtNAME
            // 
            this.txtNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNAME.DefaultText = "";
            this.txtNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNAME.DisabledState.Parent = this.txtNAME;
            this.txtNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNAME.FocusedState.Parent = this.txtNAME;
            this.txtNAME.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNAME.HoverState.Parent = this.txtNAME;
            this.txtNAME.Location = new System.Drawing.Point(36, 159);
            this.txtNAME.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.PasswordChar = '\0';
            this.txtNAME.PlaceholderText = "Enter Full Name";
            this.txtNAME.SelectedText = "";
            this.txtNAME.ShadowDecoration.Parent = this.txtNAME;
            this.txtNAME.Size = new System.Drawing.Size(589, 36);
            this.txtNAME.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNAME.TabIndex = 8;
            this.txtNAME.TextChanged += new System.EventHandler(this.txtNAME_TextChanged);
            this.txtNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNAME_KeyDown);
            // 
            // txtcontact
            // 
            this.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontact.DefaultText = "";
            this.txtcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontact.DisabledState.Parent = this.txtcontact;
            this.txtcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontact.FocusedState.Parent = this.txtcontact;
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontact.HoverState.Parent = this.txtcontact;
            this.txtcontact.Location = new System.Drawing.Point(36, 308);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.PlaceholderText = "Enter Contact No";
            this.txtcontact.SelectedText = "";
            this.txtcontact.ShadowDecoration.Parent = this.txtcontact;
            this.txtcontact.Size = new System.Drawing.Size(589, 36);
            this.txtcontact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtcontact.TabIndex = 9;
            this.txtcontact.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            this.txtcontact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontact_KeyDown);
            // 
            // txtnationality
            // 
            this.txtnationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnationality.DefaultText = "";
            this.txtnationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnationality.DisabledState.Parent = this.txtnationality;
            this.txtnationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnationality.FocusedState.Parent = this.txtnationality;
            this.txtnationality.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtnationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnationality.HoverState.Parent = this.txtnationality;
            this.txtnationality.Location = new System.Drawing.Point(36, 458);
            this.txtnationality.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtnationality.Name = "txtnationality";
            this.txtnationality.PasswordChar = '\0';
            this.txtnationality.PlaceholderText = "Nationality";
            this.txtnationality.SelectedText = "";
            this.txtnationality.ShadowDecoration.Parent = this.txtnationality;
            this.txtnationality.Size = new System.Drawing.Size(589, 36);
            this.txtnationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtnationality.TabIndex = 10;
            this.txtnationality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnationality_KeyDown);
            // 
            // txtgender
            // 
            this.txtgender.BackColor = System.Drawing.Color.Transparent;
            this.txtgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgender.FocusedState.Parent = this.txtgender;
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgender.HoverState.Parent = this.txtgender;
            this.txtgender.ItemHeight = 30;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgender.ItemsAppearance.Parent = this.txtgender;
            this.txtgender.Location = new System.Drawing.Point(36, 589);
            this.txtgender.Name = "txtgender";
            this.txtgender.ShadowDecoration.Parent = this.txtgender;
            this.txtgender.Size = new System.Drawing.Size(589, 36);
            this.txtgender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtgender.TabIndex = 11;
            // 
            // txtdob
            // 
            this.txtdob.CheckedState.BorderColor = System.Drawing.Color.White;
            this.txtdob.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txtdob.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtdob.CheckedState.Parent = this.txtdob;
            this.txtdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdob.HoverState.Parent = this.txtdob;
            this.txtdob.Location = new System.Drawing.Point(36, 710);
            this.txtdob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdob.Name = "txtdob";
            this.txtdob.ShadowDecoration.Parent = this.txtdob;
            this.txtdob.Size = new System.Drawing.Size(589, 36);
            this.txtdob.TabIndex = 12;
            this.txtdob.Value = new System.DateTime(2023, 5, 30, 21, 46, 17, 762);
            this.txtdob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdob_KeyDown);
            // 
            // txtcheckin
            // 
            this.txtcheckin.CheckedState.BorderColor = System.Drawing.Color.White;
            this.txtcheckin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txtcheckin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtcheckin.CheckedState.Parent = this.txtcheckin;
            this.txtcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcheckin.HoverState.Parent = this.txtcheckin;
            this.txtcheckin.Location = new System.Drawing.Point(688, 455);
            this.txtcheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtcheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtcheckin.Name = "txtcheckin";
            this.txtcheckin.ShadowDecoration.Parent = this.txtcheckin;
            this.txtcheckin.Size = new System.Drawing.Size(589, 36);
            this.txtcheckin.TabIndex = 18;
            this.txtcheckin.Value = new System.DateTime(2023, 5, 30, 21, 22, 10, 527);
            this.txtcheckin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckin_KeyDown);
            // 
            // txtaddress
            // 
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.Parent = this.txtaddress;
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedState.Parent = this.txtaddress;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.HoverState.Parent = this.txtaddress;
            this.txtaddress.Location = new System.Drawing.Point(688, 308);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "Complete Address";
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(589, 36);
            this.txtaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtaddress.TabIndex = 17;
            // 
            // txtidproof
            // 
            this.txtidproof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidproof.DefaultText = "";
            this.txtidproof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidproof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidproof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidproof.DisabledState.Parent = this.txtidproof;
            this.txtidproof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidproof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidproof.FocusedState.Parent = this.txtidproof;
            this.txtidproof.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtidproof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtidproof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidproof.HoverState.Parent = this.txtidproof;
            this.txtidproof.Location = new System.Drawing.Point(688, 159);
            this.txtidproof.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtidproof.Name = "txtidproof";
            this.txtidproof.PasswordChar = '\0';
            this.txtidproof.PlaceholderText = "Enter ID";
            this.txtidproof.SelectedText = "";
            this.txtidproof.ShadowDecoration.Parent = this.txtidproof;
            this.txtidproof.Size = new System.Drawing.Size(589, 36);
            this.txtidproof.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtidproof.TabIndex = 16;
            this.txtidproof.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidproof_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(688, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Check In";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(688, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(688, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID Proof";
            // 
            // txtbed
            // 
            this.txtbed.BackColor = System.Drawing.Color.Transparent;
            this.txtbed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtbed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.FocusedState.Parent = this.txtbed;
            this.txtbed.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtbed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbed.HoverState.Parent = this.txtbed;
            this.txtbed.ItemHeight = 30;
            this.txtbed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "triple"});
            this.txtbed.ItemsAppearance.Parent = this.txtbed;
            this.txtbed.Location = new System.Drawing.Point(1341, 156);
            this.txtbed.Name = "txtbed";
            this.txtbed.ShadowDecoration.Parent = this.txtbed;
            this.txtbed.Size = new System.Drawing.Size(589, 36);
            this.txtbed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbed.TabIndex = 20;
            this.txtbed.SelectedIndexChanged += new System.EventHandler(this.txtbed_SelectedIndexChanged);
            this.txtbed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbed_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1337, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bed";
            // 
            // txtroomtype
            // 
            this.txtroomtype.BackColor = System.Drawing.Color.Transparent;
            this.txtroomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtroomtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomtype.FocusedState.Parent = this.txtroomtype;
            this.txtroomtype.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtroomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtroomtype.HoverState.Parent = this.txtroomtype;
            this.txtroomtype.ItemHeight = 30;
            this.txtroomtype.Items.AddRange(new object[] {
            "Classic",
            "Deluxe"});
            this.txtroomtype.ItemsAppearance.Parent = this.txtroomtype;
            this.txtroomtype.Location = new System.Drawing.Point(1341, 305);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.ShadowDecoration.Parent = this.txtroomtype;
            this.txtroomtype.Size = new System.Drawing.Size(589, 36);
            this.txtroomtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtroomtype.TabIndex = 22;
            this.txtroomtype.SelectedIndexChanged += new System.EventHandler(this.txtroomtype_SelectedIndexChanged);
            this.txtroomtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtroomtype_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1337, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Room Type";
            // 
            // txtroomno
            // 
            this.txtroomno.BackColor = System.Drawing.Color.Transparent;
            this.txtroomno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtroomno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomno.FocusedState.Parent = this.txtroomno;
            this.txtroomno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtroomno.HoverState.Parent = this.txtroomno;
            this.txtroomno.ItemHeight = 30;
            this.txtroomno.ItemsAppearance.Parent = this.txtroomno;
            this.txtroomno.Location = new System.Drawing.Point(1341, 455);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.ShadowDecoration.Parent = this.txtroomno;
            this.txtroomno.Size = new System.Drawing.Size(589, 36);
            this.txtroomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtroomno.TabIndex = 24;
            this.txtroomno.SelectedIndexChanged += new System.EventHandler(this.txtroomno_SelectedIndexChanged);
            this.txtroomno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtroomno_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1337, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Room No";
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.Parent = this.txtprice;
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.FocusedState.Parent = this.txtprice;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.HoverState.Parent = this.txtprice;
            this.txtprice.Location = new System.Drawing.Point(1341, 592);
            this.txtprice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "Total Price ";
            this.txtprice.ReadOnly = true;
            this.txtprice.SelectedText = "";
            this.txtprice.ShadowDecoration.Parent = this.txtprice;
            this.txtprice.Size = new System.Drawing.Size(589, 36);
            this.txtprice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtprice.TabIndex = 26;
            this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1337, 564);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Price";
            // 
            // btnAlloateroom
            // 
            this.btnAlloateroom.BorderRadius = 25;
            this.btnAlloateroom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAlloateroom.BorderThickness = 1;
            this.btnAlloateroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAlloateroom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAlloateroom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAlloateroom.CheckedState.Parent = this.btnAlloateroom;
            this.btnAlloateroom.CustomImages.Parent = this.btnAlloateroom;
            this.btnAlloateroom.FillColor = System.Drawing.Color.White;
            this.btnAlloateroom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlloateroom.ForeColor = System.Drawing.Color.Black;
            this.btnAlloateroom.HoverState.Parent = this.btnAlloateroom;
            this.btnAlloateroom.Image = ((System.Drawing.Image)(resources.GetObject("btnAlloateroom.Image")));
            this.btnAlloateroom.ImageSize = new System.Drawing.Size(39, 39);
            this.btnAlloateroom.Location = new System.Drawing.Point(1698, 710);
            this.btnAlloateroom.Name = "btnAlloateroom";
            this.btnAlloateroom.ShadowDecoration.Parent = this.btnAlloateroom;
            this.btnAlloateroom.Size = new System.Drawing.Size(232, 61);
            this.btnAlloateroom.TabIndex = 27;
            this.btnAlloateroom.Text = "Alloate Room";
            this.btnAlloateroom.Click += new System.EventHandler(this.btnAlloateroom_Click);
            // 
            // uccustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAlloateroom);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtroomno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtidproof);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtnationality);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uccustomer";
            this.Size = new System.Drawing.Size(1947, 814);
            this.Load += new System.EventHandler(this.uccustomer_Load_1);
            this.Leave += new System.EventHandler(this.uccustomer_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtnationality;
        private Guna.UI2.WinForms.Guna2TextBox txtcontact;
        private Guna.UI2.WinForms.Guna2TextBox txtNAME;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdob;
        private Guna.UI2.WinForms.Guna2ComboBox txtgender;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox txtroomno;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox txtroomtype;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox txtbed;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtcheckin;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtidproof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnAlloateroom;
    }
}
