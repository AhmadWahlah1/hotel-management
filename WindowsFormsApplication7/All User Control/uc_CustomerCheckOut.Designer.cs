namespace WindowsFormsApplication7.All_User_Control
{
    partial class uc_CustomerCheckOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_CustomerCheckOut));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.roomno = new System.Windows.Forms.Label();
            this.Checkout = new System.Windows.Forms.Label();
            this.txtcheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtroomn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnam = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView21 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btncheck = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView21)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lname
            // 
            resources.ApplyResources(this.lname, "lname");
            this.lname.Name = "lname";
            this.lname.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelname
            // 
            resources.ApplyResources(this.labelname, "labelname");
            this.labelname.Name = "labelname";
            // 
            // roomno
            // 
            resources.ApplyResources(this.roomno, "roomno");
            this.roomno.Name = "roomno";
            // 
            // Checkout
            // 
            resources.ApplyResources(this.Checkout, "Checkout");
            this.Checkout.Name = "Checkout";
            // 
            // txtcheckout
            // 
            resources.ApplyResources(this.txtcheckout, "txtcheckout");
            this.txtcheckout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.txtcheckout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txtcheckout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtcheckout.CheckedState.Parent = this.txtcheckout;
            this.txtcheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcheckout.HoverState.Parent = this.txtcheckout;
            this.txtcheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtcheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtcheckout.Name = "txtcheckout";
            this.txtcheckout.ShadowDecoration.Parent = this.txtcheckout;
            this.txtcheckout.Value = new System.DateTime(2023, 5, 30, 21, 22, 10, 527);
            this.txtcheckout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckout_KeyDown);
            // 
            // txtname
            // 
            resources.ApplyResources(this.txtname, "txtname");
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Enter Full Name";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // txtroomn
            // 
            resources.ApplyResources(this.txtroomn, "txtroomn");
            this.txtroomn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomn.DefaultText = "";
            this.txtroomn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtroomn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtroomn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomn.DisabledState.Parent = this.txtroomn;
            this.txtroomn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomn.FocusedState.Parent = this.txtroomn;
            this.txtroomn.ForeColor = System.Drawing.Color.Black;
            this.txtroomn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomn.HoverState.Parent = this.txtroomn;
            this.txtroomn.Name = "txtroomn";
            this.txtroomn.PasswordChar = '\0';
            this.txtroomn.PlaceholderText = "Room No";
            this.txtroomn.ReadOnly = true;
            this.txtroomn.SelectedText = "";
            this.txtroomn.ShadowDecoration.Parent = this.txtroomn;
            this.txtroomn.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // txtnam
            // 
            resources.ApplyResources(this.txtnam, "txtnam");
            this.txtnam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnam.DefaultText = "";
            this.txtnam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnam.DisabledState.Parent = this.txtnam;
            this.txtnam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnam.FocusedState.Parent = this.txtnam;
            this.txtnam.ForeColor = System.Drawing.Color.Black;
            this.txtnam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnam.HoverState.Parent = this.txtnam;
            this.txtnam.Name = "txtnam";
            this.txtnam.PasswordChar = '\0';
            this.txtnam.PlaceholderText = "Enter Full Name";
            this.txtnam.ReadOnly = true;
            this.txtnam.SelectedText = "";
            this.txtnam.ShadowDecoration.Parent = this.txtnam;
            this.txtnam.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // guna2DataGridView21
            // 
            resources.ApplyResources(this.guna2DataGridView21, "guna2DataGridView21");
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView21.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView21.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView21.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView21.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView21.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView21.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView21.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView21.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView21.EnableHeadersVisualStyles = false;
            this.guna2DataGridView21.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView21.Name = "guna2DataGridView21";
            this.guna2DataGridView21.RowHeadersVisible = false;
            this.guna2DataGridView21.RowTemplate.Height = 24;
            this.guna2DataGridView21.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView21.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView21.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView21.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView21.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView21.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView21.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView21.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView21.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView21.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView21.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView21.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView21.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView21.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView21.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView21.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView21.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView21.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView21.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView21_CellContentClick);
            // 
            // btncheck
            // 
            resources.ApplyResources(this.btncheck, "btncheck");
            this.btncheck.BorderRadius = 25;
            this.btncheck.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btncheck.BorderThickness = 1;
            this.btncheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btncheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btncheck.CheckedState.Parent = this.btncheck;
            this.btncheck.CustomImages.Parent = this.btncheck;
            this.btncheck.FillColor = System.Drawing.Color.White;
            this.btncheck.ForeColor = System.Drawing.Color.Black;
            this.btncheck.HoverState.Parent = this.btncheck;
            this.btncheck.Image = ((System.Drawing.Image)(resources.GetObject("btncheck.Image")));
            this.btncheck.ImageSize = new System.Drawing.Size(39, 39);
            this.btncheck.Name = "btncheck";
            this.btncheck.ShadowDecoration.Parent = this.btncheck;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            this.btncheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncheck_KeyDown);
            // 
            // uc_CustomerCheckOut
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.guna2DataGridView21);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtroomn);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcheckout);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.roomno);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Name = "uc_CustomerCheckOut";
            this.Load += new System.EventHandler(this.uc_CustomerCheckOut_Load);
            this.Leave += new System.EventHandler(this.uc_CustomerCheckOut_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label roomno;
        private System.Windows.Forms.Label Checkout;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtcheckout;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView21;
        private Guna.UI2.WinForms.Guna2TextBox txtnam;
        private Guna.UI2.WinForms.Guna2TextBox txtroomn;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button btncheck;
    }
}
