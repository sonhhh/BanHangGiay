﻿namespace DoAnNet001.Views.ucSanPham
{
    partial class DSctSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_KichCo = new System.Windows.Forms.TextBox();
            this.txt_MauSac = new System.Windows.Forms.TextBox();
            this.txt_ChatLieu = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_MaChiTietSanPham = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaSp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaCTSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_MaChiTietSanPham);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_GiaBan);
            this.panel1.Controls.Add(this.txt_ChatLieu);
            this.panel1.Controls.Add(this.txt_MauSac);
            this.panel1.Controls.Add(this.txt_KichCo);
            this.panel1.Controls.Add(this.btn_KhoiPhuc);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_DanhSach);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 485);
            this.panel1.TabIndex = 0;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(740, 25);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(144, 23);
            this.btn_KhoiPhuc.TabIndex = 9;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = true;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Danh sách đã xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(740, 82);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(144, 23);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.Location = new System.Drawing.Point(740, 111);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(144, 23);
            this.btn_DanhSach.TabIndex = 6;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = true;
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(22, 96);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập tên sản phẩm cần tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn sản phẩm:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(22, 70);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(192, 20);
            this.txt_search.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.MaSp,
            this.MaCTSp,
            this.KichCo,
            this.MaSac,
            this.ChatLieu,
            this.SoLuong,
            this.GiaBan,
            this.TinhTrang});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1073, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_KichCo
            // 
            this.txt_KichCo.Location = new System.Drawing.Point(301, 28);
            this.txt_KichCo.Name = "txt_KichCo";
            this.txt_KichCo.Size = new System.Drawing.Size(157, 20);
            this.txt_KichCo.TabIndex = 10;
            // 
            // txt_MauSac
            // 
            this.txt_MauSac.Location = new System.Drawing.Point(301, 73);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.Size = new System.Drawing.Size(157, 20);
            this.txt_MauSac.TabIndex = 11;
            // 
            // txt_ChatLieu
            // 
            this.txt_ChatLieu.Location = new System.Drawing.Point(540, 29);
            this.txt_ChatLieu.Name = "txt_ChatLieu";
            this.txt_ChatLieu.Size = new System.Drawing.Size(158, 20);
            this.txt_ChatLieu.TabIndex = 12;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(540, 74);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(158, 20);
            this.txt_GiaBan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kích cỡ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Màu sắc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chất liệu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giá bán:";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(540, 100);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhat.TabIndex = 18;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã chi tiết sản phẩm:";
            // 
            // lb_MaChiTietSanPham
            // 
            this.lb_MaChiTietSanPham.AutoSize = true;
            this.lb_MaChiTietSanPham.Location = new System.Drawing.Point(406, 111);
            this.lb_MaChiTietSanPham.Name = "lb_MaChiTietSanPham";
            this.lb_MaChiTietSanPham.Size = new System.Drawing.Size(25, 13);
            this.lb_MaChiTietSanPham.TabIndex = 20;
            this.lb_MaChiTietSanPham.Text = "001";
            // 
            // Xoa
            // 
            this.Xoa.FillWeight = 30F;
            this.Xoa.HeaderText = "";
            this.Xoa.Name = "Xoa";
            // 
            // MaSp
            // 
            this.MaSp.DataPropertyName = "MaSp";
            this.MaSp.FillWeight = 98.90017F;
            this.MaSp.HeaderText = "Sản phẩm";
            this.MaSp.Name = "MaSp";
            // 
            // MaCTSp
            // 
            this.MaCTSp.DataPropertyName = "MaCTSp";
            this.MaCTSp.HeaderText = "Mã chi tiết sản phẩm";
            this.MaCTSp.Name = "MaCTSp";
            this.MaCTSp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaCTSp.Visible = false;
            // 
            // KichCo
            // 
            this.KichCo.DataPropertyName = "KichCo";
            this.KichCo.FillWeight = 98.90017F;
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.Name = "KichCo";
            this.KichCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KichCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaSac
            // 
            this.MaSac.DataPropertyName = "MaSac";
            this.MaSac.FillWeight = 98.90017F;
            this.MaSac.HeaderText = "Màu sắc";
            this.MaSac.Name = "MaSac";
            // 
            // ChatLieu
            // 
            this.ChatLieu.DataPropertyName = "ChatLieu";
            this.ChatLieu.FillWeight = 98.90017F;
            this.ChatLieu.HeaderText = "Chất liệu";
            this.ChatLieu.Name = "ChatLieu";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 98.90017F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.FillWeight = 98.90017F;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = false;
            // 
            // DSctSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DSctSanPham";
            this.Size = new System.Drawing.Size(1073, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_DanhSach;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.TextBox txt_ChatLieu;
        private System.Windows.Forms.TextBox txt_MauSac;
        private System.Windows.Forms.TextBox txt_KichCo;
        private System.Windows.Forms.Label lb_MaChiTietSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xoa;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
    }
}
