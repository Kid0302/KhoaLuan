﻿namespace GUI
{
    partial class frmLichSuXoaHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuXoaHD));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvListHDIsDeleted = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsBtn_Lammoi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Khoiphuc = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTK = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTk = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHDIsDeleted)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.dgvListHDIsDeleted;
            // 
            // dgvListHDIsDeleted
            // 
            this.dgvListHDIsDeleted.AllowUserToAddRows = false;
            this.dgvListHDIsDeleted.AllowUserToDeleteRows = false;
            this.dgvListHDIsDeleted.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListHDIsDeleted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListHDIsDeleted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListHDIsDeleted.ColumnHeadersHeight = 35;
            this.dgvListHDIsDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListHDIsDeleted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.TongTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListHDIsDeleted.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListHDIsDeleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListHDIsDeleted.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListHDIsDeleted.Location = new System.Drawing.Point(0, 143);
            this.dgvListHDIsDeleted.Name = "dgvListHDIsDeleted";
            this.dgvListHDIsDeleted.ReadOnly = true;
            this.dgvListHDIsDeleted.RowHeadersVisible = false;
            this.dgvListHDIsDeleted.RowHeadersWidth = 51;
            this.dgvListHDIsDeleted.RowTemplate.Height = 24;
            this.dgvListHDIsDeleted.Size = new System.Drawing.Size(1022, 553);
            this.dgvListHDIsDeleted.TabIndex = 11;
            this.dgvListHDIsDeleted.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListHDIsDeleted.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListHDIsDeleted.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListHDIsDeleted.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListHDIsDeleted.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListHDIsDeleted.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListHDIsDeleted.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListHDIsDeleted.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvListHDIsDeleted.ThemeStyle.ReadOnly = true;
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListHDIsDeleted.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListHDIsDeleted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListHDIsDeleted_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hoá đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // tsBtn_Lammoi
            // 
            this.tsBtn_Lammoi.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Lammoi.Image")));
            this.tsBtn_Lammoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Lammoi.Name = "tsBtn_Lammoi";
            this.tsBtn_Lammoi.Size = new System.Drawing.Size(112, 29);
            this.tsBtn_Lammoi.Text = "Làm mới";
            this.tsBtn_Lammoi.Click += new System.EventHandler(this.tsBtn_Lammoi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Khoiphuc,
            this.tsBtn_Lammoi,
            this.tsBtn_Thoat,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 32);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Khoiphuc
            // 
            this.tsBtn_Khoiphuc.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Khoiphuc.Image")));
            this.tsBtn_Khoiphuc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Khoiphuc.Name = "tsBtn_Khoiphuc";
            this.tsBtn_Khoiphuc.Size = new System.Drawing.Size(125, 29);
            this.tsBtn_Khoiphuc.Text = "Khôi phục";
            this.tsBtn_Khoiphuc.Click += new System.EventHandler(this.tsBtn_Khoiphuc_Click);
            // 
            // tsBtn_Thoat
            // 
            this.tsBtn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Thoat.Image")));
            this.tsBtn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Thoat.Name = "tsBtn_Thoat";
            this.tsBtn_Thoat.Size = new System.Drawing.Size(107, 29);
            this.tsBtn_Thoat.Text = "Quay lại";
            this.tsBtn_Thoat.Click += new System.EventHandler(this.tsBtn_Thoat_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 29);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Tìm kiếm";
            // 
            // tbTK
            // 
            this.tbTK.AllowLinksHandling = true;
            this.tbTK.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AutoRoundedCorners = true;
            this.txtBoxSearch.BorderRadius = 20;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Location = new System.Drawing.Point(110, 68);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderText = "Nhập thông tin cần tìm";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(266, 43);
            this.txtBoxSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTk);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 143);
            this.panel1.TabIndex = 10;
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.Transparent;
            this.btnTk.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTk.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnTk.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTk.Image = ((System.Drawing.Image)(resources.GetObject("btnTk.Image")));
            this.btnTk.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTk.ImageRotate = 0F;
            this.btnTk.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTk.IndicateFocus = true;
            this.btnTk.Location = new System.Drawing.Point(394, 65);
            this.btnTk.Name = "btnTk";
            this.btnTk.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnTk.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTk.Size = new System.Drawing.Size(50, 50);
            this.btnTk.TabIndex = 77;
            this.btnTk.UseTransparentBackground = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // frmLichSuXoaHD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(49)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1022, 696);
            this.Controls.Add(this.dgvListHDIsDeleted);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichSuXoaHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLichSuXoaHD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHDIsDeleted)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListHDIsDeleted;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Khoiphuc;
        private System.Windows.Forms.ToolStripButton tsBtn_Lammoi;
        private System.Windows.Forms.ToolStripButton tsBtn_Thoat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tbTK;
        private Guna.UI2.WinForms.Guna2ImageButton btnTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}