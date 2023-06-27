namespace WindowsFormsApplication7.All_User_Control
{
    partial class CustomerDetails
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.customerdetail = new System.Windows.Forms.Label();
            this.lnamee = new System.Windows.Forms.Label();
            this.txtsearchby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DataGridView5 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // customerdetail
            // 
            this.customerdetail.AutoSize = true;
            this.customerdetail.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerdetail.Location = new System.Drawing.Point(36, 36);
            this.customerdetail.Name = "customerdetail";
            this.customerdetail.Size = new System.Drawing.Size(284, 40);
            this.customerdetail.TabIndex = 2;
            this.customerdetail.Text = "Customer Details";
            // 
            // lnamee
            // 
            this.lnamee.AutoSize = true;
            this.lnamee.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnamee.Location = new System.Drawing.Point(610, 110);
            this.lnamee.Name = "lnamee";
            this.lnamee.Size = new System.Drawing.Size(101, 22);
            this.lnamee.TabIndex = 5;
            this.lnamee.Text = "Search By";
            // 
            // txtsearchby
            // 
            this.txtsearchby.BackColor = System.Drawing.Color.Transparent;
            this.txtsearchby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsearchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsearchby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchby.FocusedState.Parent = this.txtsearchby;
            this.txtsearchby.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtsearchby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsearchby.HoverState.Parent = this.txtsearchby;
            this.txtsearchby.ItemHeight = 30;
            this.txtsearchby.Items.AddRange(new object[] {
            "All Customer Details",
            "In Hotel Customer",
            "CheckOut Customer"});
            this.txtsearchby.ItemsAppearance.Parent = this.txtsearchby;
            this.txtsearchby.Location = new System.Drawing.Point(614, 135);
            this.txtsearchby.Name = "txtsearchby";
            this.txtsearchby.ShadowDecoration.Parent = this.txtsearchby;
            this.txtsearchby.Size = new System.Drawing.Size(589, 36);
            this.txtsearchby.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtsearchby.TabIndex = 23;
            this.txtsearchby.SelectedIndexChanged += new System.EventHandler(this.txtsearchby_SelectedIndexChanged);
            // 
            // guna2DataGridView5
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView5.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView5.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView5.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView5.EnableHeadersVisualStyles = false;
            this.guna2DataGridView5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.Location = new System.Drawing.Point(43, 203);
            this.guna2DataGridView5.Name = "guna2DataGridView5";
            this.guna2DataGridView5.RowHeadersVisible = false;
            this.guna2DataGridView5.RowTemplate.Height = 24;
            this.guna2DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView5.Size = new System.Drawing.Size(1879, 473);
            this.guna2DataGridView5.TabIndex = 24;
            this.guna2DataGridView5.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView5.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView5.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView5_CellContentClick);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2DataGridView5);
            this.Controls.Add(this.txtsearchby);
            this.Controls.Add(this.lnamee);
            this.Controls.Add(this.customerdetail);
            this.Name = "CustomerDetails";
            this.Size = new System.Drawing.Size(1947, 814);
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label customerdetail;
        private System.Windows.Forms.Label lnamee;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView5;
        private Guna.UI2.WinForms.Guna2ComboBox txtsearchby;
    }
}
