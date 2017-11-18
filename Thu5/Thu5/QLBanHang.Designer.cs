namespace Thu5
{
    partial class QLBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xem_sp = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.gb_ds_sp = new System.Windows.Forms.GroupBox();
            this.data_ds_sp = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbb_hang = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lb_xinchao = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_ds_sp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ds_sp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(86, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG BÁN LAPTOP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_xem_sp);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.gb_ds_sp);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Location = new System.Drawing.Point(17, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_xem_sp
            // 
            this.bt_xem_sp.Location = new System.Drawing.Point(437, 374);
            this.bt_xem_sp.Name = "bt_xem_sp";
            this.bt_xem_sp.Size = new System.Drawing.Size(138, 33);
            this.bt_xem_sp.TabIndex = 8;
            this.bt_xem_sp.Text = "Xem chi tiết sản phẩm";
            this.bt_xem_sp.UseVisualStyleBackColor = true;
            this.bt_xem_sp.Click += new System.EventHandler(this.bt_xem_sp_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(15, 374);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 7;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            // 
            // gb_ds_sp
            // 
            this.gb_ds_sp.Controls.Add(this.data_ds_sp);
            this.gb_ds_sp.Location = new System.Drawing.Point(9, 54);
            this.gb_ds_sp.Name = "gb_ds_sp";
            this.gb_ds_sp.Size = new System.Drawing.Size(566, 314);
            this.gb_ds_sp.TabIndex = 6;
            this.gb_ds_sp.TabStop = false;
            this.gb_ds_sp.Text = "Danh sách sản phẩm:";
            // 
            // data_ds_sp
            // 
            this.data_ds_sp.AllowUserToAddRows = false;
            this.data_ds_sp.AllowUserToDeleteRows = false;
            this.data_ds_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ds_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.Hang,
            this.SoLuong,
            this.DonGia});
            this.data_ds_sp.Location = new System.Drawing.Point(6, 19);
            this.data_ds_sp.Name = "data_ds_sp";
            this.data_ds_sp.ReadOnly = true;
            this.data_ds_sp.Size = new System.Drawing.Size(554, 279);
            this.data_ds_sp.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_timkiem);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.cbb_hang);
            this.panel3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(9, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 33);
            this.panel3.TabIndex = 5;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_timkiem.Location = new System.Drawing.Point(3, 8);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(220, 20);
            this.txt_timkiem.TabIndex = 27;
            this.txt_timkiem.Text = "Nhập tên sản phẩm cần tìm kiếm";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Thu5.Properties.Resources.if_system_search_118797;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(356, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 23);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbb_hang
            // 
            this.cbb_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbb_hang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbb_hang.FormattingEnabled = true;
            this.cbb_hang.Items.AddRange(new object[] {
            "Asus",
            "Dell",
            "HP"});
            this.cbb_hang.Location = new System.Drawing.Point(229, 7);
            this.cbb_hang.Name = "cbb_hang";
            this.cbb_hang.Size = new System.Drawing.Size(121, 21);
            this.cbb_hang.TabIndex = 25;
            this.cbb_hang.Text = "Hãng";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Thu5.Properties.Resources.if_Cart_877015;
            this.pictureBox7.Location = new System.Drawing.Point(541, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 33);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // lb_xinchao
            // 
            this.lb_xinchao.AutoSize = true;
            this.lb_xinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xinchao.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_xinchao.Location = new System.Drawing.Point(498, 55);
            this.lb_xinchao.Name = "lb_xinchao";
            this.lb_xinchao.Size = new System.Drawing.Size(94, 16);
            this.lb_xinchao.TabIndex = 2;
            this.lb_xinchao.Text = "Xin chào user !";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // Hang
            // 
            this.Hang.HeaderText = "Hãng";
            this.Hang.Name = "Hang";
            this.Hang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // QLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 500);
            this.Controls.Add(this.lb_xinchao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QLBanHang";
            this.Text = "Hệ thống bán Laptop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gb_ds_sp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ds_sp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_hang;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lb_xinchao;
        private System.Windows.Forms.GroupBox gb_ds_sp;
        private System.Windows.Forms.DataGridView data_ds_sp;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xem_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}

