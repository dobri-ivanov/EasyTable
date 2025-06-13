
namespace EasyTable
{
    partial class Home
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.PageAdmin = new System.Windows.Forms.TabPage();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options = new System.Windows.Forms.DataGridViewImageColumn();
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.navBar1 = new EasyTable.Forms.Controls.NavBar();
            this.header1 = new EasyTable.Forms.Controls.Header();
            this.OptionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuPages1.SuspendLayout();
            this.PageAdmin.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.OptionsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.PageAdmin);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(200, 40);
            this.bunifuPages1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.PageAdmin;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "PageAdmin";
            this.bunifuPages1.PageTitle = "tabPageAdmin";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1000, 691);
            this.bunifuPages1.TabIndex = 4;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // PageAdmin
            // 
            this.PageAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.PageAdmin.Controls.Add(this.bunifuPanel2);
            this.PageAdmin.Controls.Add(this.bunifuPanel1);
            this.PageAdmin.Location = new System.Drawing.Point(4, 4);
            this.PageAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.PageAdmin.Name = "PageAdmin";
            this.PageAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.PageAdmin.Size = new System.Drawing.Size(992, 665);
            this.PageAdmin.TabIndex = 0;
            this.PageAdmin.Text = "tabPageAdmin";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuDataGridView1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(2, 70);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(988, 593);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = true;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            this.bunifuDataGridView1.AllowUserToOrderColumns = true;
            this.bunifuDataGridView1.AllowUserToResizeColumns = false;
            this.bunifuDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn,
            this.Options});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView1.DataSource = this.userDtoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DimGray;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.MultiSelect = false;
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.RowTemplate.ReadOnly = true;
            this.bunifuDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.ShowCellErrors = false;
            this.bunifuDataGridView1.ShowCellToolTips = false;
            this.bunifuDataGridView1.ShowEditingIcon = false;
            this.bunifuDataGridView1.ShowRowErrors = false;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(988, 593);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.bunifuDataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellMouseEnter);
            this.bunifuDataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellMouseLeave);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 25F;
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Потребител";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Длъжност";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "Контакти";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            this.contactInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Options
            // 
            this.Options.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Options.FillWeight = 13F;
            this.Options.HeaderText = "";
            this.Options.Image = global::EasyTable.Properties.Resources.icon_options_new;
            this.Options.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Options.Name = "Options";
            this.Options.ReadOnly = true;
            this.Options.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Options.Width = 36;
            // 
            // userDtoBindingSource
            // 
            this.userDtoBindingSource.DataSource = typeof(EasyTable.Data.Dtos.UserDto);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(2, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(988, 68);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(16, 18);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(151, 25);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Администрация";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // navBar1
            // 
            this.navBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.navBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar1.Location = new System.Drawing.Point(0, 40);
            this.navBar1.Margin = new System.Windows.Forms.Padding(4);
            this.navBar1.Name = "navBar1";
            this.navBar1.Size = new System.Drawing.Size(200, 691);
            this.navBar1.TabIndex = 3;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1200, 40);
            this.header1.TabIndex = 2;
            // 
            // OptionsMenuStrip
            // 
            this.OptionsMenuStrip.AutoSize = false;
            this.OptionsMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.OptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.OptionsMenuStrip.Name = "OptionsMenuStrip";
            this.OptionsMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OptionsMenuStrip.ShowImageMargin = false;
            this.OptionsMenuStrip.ShowItemToolTips = false;
            this.OptionsMenuStrip.Size = new System.Drawing.Size(156, 92);
            this.OptionsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.OptionsMenuStrip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem1.Text = "Детайли";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "Редактирай";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem3.Text = "Изтрий";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.navBar1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTable Software";
            this.bunifuPages1.ResumeLayout(false);
            this.PageAdmin.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.OptionsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.Controls.Header header1;
        private Forms.Controls.NavBar navBar1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage PageAdmin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        public Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Options;
        private System.Windows.Forms.ContextMenuStrip OptionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

