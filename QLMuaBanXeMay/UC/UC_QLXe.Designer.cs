﻿namespace QLMuaBanXeMay
{
    partial class UC_QLXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xeMayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLMuaBanXeMayDataSet = new QLMuaBanXeMay.QLMuaBanXeMayDataSet();
            this.xeMayTableAdapter = new QLMuaBanXeMay.QLMuaBanXeMayDataSetTableAdapters.XeMayTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Xe_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.capnhat_btn = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauSacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanKhoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congSuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xeMayBindingSource
            // 
            this.xeMayBindingSource.DataMember = "XeMay";
            this.xeMayBindingSource.DataSource = this.qLMuaBanXeMayDataSet;
            // 
            // qLMuaBanXeMayDataSet
            // 
            this.qLMuaBanXeMayDataSet.DataSetName = "QLMuaBanXeMayDataSet";
            this.qLMuaBanXeMayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xeMayTableAdapter
            // 
            this.xeMayTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Xe_GridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(86, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 352);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các xe";
            // 
            // Xe_GridView
            // 
            this.Xe_GridView.AllowUserToAddRows = false;
            this.Xe_GridView.AllowUserToDeleteRows = false;
            this.Xe_GridView.AllowUserToResizeColumns = false;
            this.Xe_GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Xe_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Xe_GridView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Xe_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Xe_GridView.ColumnHeadersHeight = 50;
            this.Xe_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Xe_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXe,
            this.tenXe,
            this.donGia,
            this.loaiXeDataGridViewTextBoxColumn,
            this.mauSacDataGridViewTextBoxColumn,
            this.phanKhoiDataGridViewTextBoxColumn,
            this.congSuatDataGridViewTextBoxColumn,
            this.hangSXDataGridViewTextBoxColumn,
            this.namSXDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.Xoa_btn});
            this.Xe_GridView.DataSource = this.xeMayBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Xe_GridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.Xe_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Xe_GridView.Location = new System.Drawing.Point(11, 32);
            this.Xe_GridView.Name = "Xe_GridView";
            this.Xe_GridView.ReadOnly = true;
            this.Xe_GridView.RowHeadersVisible = false;
            this.Xe_GridView.RowHeadersWidth = 51;
            this.Xe_GridView.RowTemplate.Height = 24;
            this.Xe_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Xe_GridView.Size = new System.Drawing.Size(1118, 314);
            this.Xe_GridView.TabIndex = 2;
            this.Xe_GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Xe_GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Xe_GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Xe_GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Xe_GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Xe_GridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Xe_GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Xe_GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Xe_GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Xe_GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xe_GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Xe_GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Xe_GridView.ThemeStyle.HeaderStyle.Height = 50;
            this.Xe_GridView.ThemeStyle.ReadOnly = true;
            this.Xe_GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Xe_GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Xe_GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xe_GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Xe_GridView.ThemeStyle.RowsStyle.Height = 24;
            this.Xe_GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Xe_GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Xe_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Xe_GridView_CellContentClick_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.capnhat_btn);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(86, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(889, 41);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(195, 30);
            this.textBox10.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(737, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Năm Sản Xuất";
            // 
            // capnhat_btn
            // 
            this.capnhat_btn.Location = new System.Drawing.Point(742, 129);
            this.capnhat_btn.Name = "capnhat_btn";
            this.capnhat_btn.Size = new System.Drawing.Size(170, 38);
            this.capnhat_btn.TabIndex = 18;
            this.capnhat_btn.Text = "Xuất hóa đơn";
            this.capnhat_btn.UseVisualStyleBackColor = true;
            this.capnhat_btn.Click += new System.EventHandler(this.capnhat_btn_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(889, 82);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(195, 30);
            this.textBox9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(737, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tình trạng";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(502, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 30);
            this.textBox5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(354, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phân Khối";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(502, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(195, 30);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(354, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Công Suất";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(502, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(195, 30);
            this.textBox7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(354, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hãng Sản Xuất";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(502, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(195, 30);
            this.textBox8.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(354, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Màu Sắc";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 30);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Xe";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 30);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(4, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Xe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Xe";
            // 
            // maXe
            // 
            this.maXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maXe.DataPropertyName = "MaXe";
            this.maXe.FillWeight = 50F;
            this.maXe.HeaderText = "Mã Xe";
            this.maXe.MinimumWidth = 6;
            this.maXe.Name = "maXe";
            this.maXe.ReadOnly = true;
            // 
            // tenXe
            // 
            this.tenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenXe.DataPropertyName = "TenXe";
            this.tenXe.FillWeight = 160F;
            this.tenXe.HeaderText = "Tên Xe";
            this.tenXe.MinimumWidth = 6;
            this.tenXe.Name = "tenXe";
            this.tenXe.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGia.DataPropertyName = "DonGia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // loaiXeDataGridViewTextBoxColumn
            // 
            this.loaiXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiXeDataGridViewTextBoxColumn.DataPropertyName = "LoaiXe";
            this.loaiXeDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.loaiXeDataGridViewTextBoxColumn.HeaderText = "Loại Xe";
            this.loaiXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiXeDataGridViewTextBoxColumn.Name = "loaiXeDataGridViewTextBoxColumn";
            this.loaiXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mauSacDataGridViewTextBoxColumn
            // 
            this.mauSacDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mauSacDataGridViewTextBoxColumn.DataPropertyName = "MauSac";
            this.mauSacDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.mauSacDataGridViewTextBoxColumn.HeaderText = "Màu Sắc";
            this.mauSacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mauSacDataGridViewTextBoxColumn.Name = "mauSacDataGridViewTextBoxColumn";
            this.mauSacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phanKhoiDataGridViewTextBoxColumn
            // 
            this.phanKhoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phanKhoiDataGridViewTextBoxColumn.DataPropertyName = "PhanKhoi";
            this.phanKhoiDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.phanKhoiDataGridViewTextBoxColumn.HeaderText = "Phân Khối";
            this.phanKhoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phanKhoiDataGridViewTextBoxColumn.Name = "phanKhoiDataGridViewTextBoxColumn";
            this.phanKhoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // congSuatDataGridViewTextBoxColumn
            // 
            this.congSuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.congSuatDataGridViewTextBoxColumn.DataPropertyName = "CongSuat";
            this.congSuatDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.congSuatDataGridViewTextBoxColumn.HeaderText = "Công Suất";
            this.congSuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.congSuatDataGridViewTextBoxColumn.Name = "congSuatDataGridViewTextBoxColumn";
            this.congSuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hangSXDataGridViewTextBoxColumn
            // 
            this.hangSXDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hangSXDataGridViewTextBoxColumn.DataPropertyName = "HangSX";
            this.hangSXDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.hangSXDataGridViewTextBoxColumn.HeaderText = "Hãng Sản Xuất";
            this.hangSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hangSXDataGridViewTextBoxColumn.Name = "hangSXDataGridViewTextBoxColumn";
            this.hangSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namSXDataGridViewTextBoxColumn
            // 
            this.namSXDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namSXDataGridViewTextBoxColumn.DataPropertyName = "NamSX";
            this.namSXDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.namSXDataGridViewTextBoxColumn.HeaderText = "Năm Sản Xuất";
            this.namSXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namSXDataGridViewTextBoxColumn.Name = "namSXDataGridViewTextBoxColumn";
            this.namSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.FillWeight = 80.58823F;
            this.Xoa_btn.HeaderText = "";
            this.Xoa_btn.MinimumWidth = 6;
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.ReadOnly = true;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.UseColumnTextForButtonValue = true;
            // 
            // UC_QLXe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLXe";
            this.Size = new System.Drawing.Size(1300, 721);
            this.Load += new System.EventHandler(this.UC_QLXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource xeMayBindingSource;
        private QLMuaBanXeMayDataSet qLMuaBanXeMayDataSet;
        private QLMuaBanXeMayDataSetTableAdapters.XeMayTableAdapter xeMayTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView Xe_GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button capnhat_btn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauSacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanKhoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congSuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa_btn;
    }
}
