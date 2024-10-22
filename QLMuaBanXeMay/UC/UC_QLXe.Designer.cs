namespace QLMuaBanXeMay
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
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanPhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NamSanXuat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.capnhat_btn = new System.Windows.Forms.Button();
            this.txt_TinhTang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PhanKhoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CongSuat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_HangSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MauSac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TenXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LoaiXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(86, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 257);
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
            this.MaXe,
            this.TenXe,
            this.DonGia,
            this.LoaiXe,
            this.MauSac,
            this.PhanPhoi,
            this.CongSuat,
            this.HangSX,
            this.NamSX,
            this.TrinhTrang,
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
            this.Xe_GridView.Size = new System.Drawing.Size(1118, 208);
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
            this.Xe_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Xe_GridView_CellClick);
            this.Xe_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Xe_GridView_CellContentClick_2);
            // 
            // MaXe
            // 
            this.MaXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.FillWeight = 50F;
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // TenXe
            // 
            this.TenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.FillWeight = 160F;
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // LoaiXe
            // 
            this.LoaiXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiXe.DataPropertyName = "LoaiXe";
            this.LoaiXe.FillWeight = 80.58823F;
            this.LoaiXe.HeaderText = "Loại Xe";
            this.LoaiXe.MinimumWidth = 6;
            this.LoaiXe.Name = "LoaiXe";
            this.LoaiXe.ReadOnly = true;
            // 
            // MauSac
            // 
            this.MauSac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.FillWeight = 80.58823F;
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            this.MauSac.ReadOnly = true;
            // 
            // PhanPhoi
            // 
            this.PhanPhoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhanPhoi.DataPropertyName = "PhanKhoi";
            this.PhanPhoi.FillWeight = 80.58823F;
            this.PhanPhoi.HeaderText = "Phân Khối";
            this.PhanPhoi.MinimumWidth = 6;
            this.PhanPhoi.Name = "PhanPhoi";
            this.PhanPhoi.ReadOnly = true;
            // 
            // CongSuat
            // 
            this.CongSuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CongSuat.DataPropertyName = "CongSuat";
            this.CongSuat.FillWeight = 80.58823F;
            this.CongSuat.HeaderText = "Công Suất";
            this.CongSuat.MinimumWidth = 6;
            this.CongSuat.Name = "CongSuat";
            this.CongSuat.ReadOnly = true;
            // 
            // HangSX
            // 
            this.HangSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HangSX.DataPropertyName = "HangSX";
            this.HangSX.FillWeight = 80.58823F;
            this.HangSX.HeaderText = "Hãng Sản Xuất";
            this.HangSX.MinimumWidth = 6;
            this.HangSX.Name = "HangSX";
            this.HangSX.ReadOnly = true;
            // 
            // NamSX
            // 
            this.NamSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamSX.DataPropertyName = "NamSX";
            this.NamSX.FillWeight = 80.58823F;
            this.NamSX.HeaderText = "Năm Sản Xuất";
            this.NamSX.MinimumWidth = 6;
            this.NamSX.Name = "NamSX";
            this.NamSX.ReadOnly = true;
            // 
            // TrinhTrang
            // 
            this.TrinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrinhTrang.DataPropertyName = "TinhTrang";
            this.TrinhTrang.FillWeight = 80.58823F;
            this.TrinhTrang.HeaderText = "Tình Trạng";
            this.TrinhTrang.MinimumWidth = 6;
            this.TrinhTrang.Name = "TrinhTrang";
            this.TrinhTrang.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NamSanXuat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.capnhat_btn);
            this.groupBox1.Controls.Add(this.txt_TinhTang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_PhanKhoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_CongSuat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_HangSX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_MauSac);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_TenXe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_LoaiXe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaXe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(86, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // txt_NamSanXuat
            // 
            this.txt_NamSanXuat.Location = new System.Drawing.Point(889, 41);
            this.txt_NamSanXuat.Name = "txt_NamSanXuat";
            this.txt_NamSanXuat.Size = new System.Drawing.Size(195, 30);
            this.txt_NamSanXuat.TabIndex = 20;
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
            // txt_TinhTang
            // 
            this.txt_TinhTang.Location = new System.Drawing.Point(889, 82);
            this.txt_TinhTang.Name = "txt_TinhTang";
            this.txt_TinhTang.Size = new System.Drawing.Size(195, 30);
            this.txt_TinhTang.TabIndex = 17;
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
            // txt_PhanKhoi
            // 
            this.txt_PhanKhoi.Location = new System.Drawing.Point(502, 79);
            this.txt_PhanKhoi.Name = "txt_PhanKhoi";
            this.txt_PhanKhoi.Size = new System.Drawing.Size(195, 30);
            this.txt_PhanKhoi.TabIndex = 15;
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
            // txt_CongSuat
            // 
            this.txt_CongSuat.Location = new System.Drawing.Point(502, 115);
            this.txt_CongSuat.Name = "txt_CongSuat";
            this.txt_CongSuat.Size = new System.Drawing.Size(195, 30);
            this.txt_CongSuat.TabIndex = 13;
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
            // txt_HangSX
            // 
            this.txt_HangSX.Location = new System.Drawing.Point(502, 154);
            this.txt_HangSX.Name = "txt_HangSX";
            this.txt_HangSX.Size = new System.Drawing.Size(195, 30);
            this.txt_HangSX.TabIndex = 11;
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
            // txt_MauSac
            // 
            this.txt_MauSac.Location = new System.Drawing.Point(501, 41);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.Size = new System.Drawing.Size(195, 30);
            this.txt_MauSac.TabIndex = 9;
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
            // txt_TenXe
            // 
            this.txt_TenXe.Location = new System.Drawing.Point(92, 79);
            this.txt_TenXe.Name = "txt_TenXe";
            this.txt_TenXe.Size = new System.Drawing.Size(195, 30);
            this.txt_TenXe.TabIndex = 7;
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
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(92, 115);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(195, 30);
            this.txt_DonGia.TabIndex = 5;
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
            // txt_LoaiXe
            // 
            this.txt_LoaiXe.Location = new System.Drawing.Point(92, 151);
            this.txt_LoaiXe.Name = "txt_LoaiXe";
            this.txt_LoaiXe.Size = new System.Drawing.Size(195, 30);
            this.txt_LoaiXe.TabIndex = 3;
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
            // txt_MaXe
            // 
            this.txt_MaXe.Location = new System.Drawing.Point(92, 43);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(195, 30);
            this.txt_MaXe.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Xe";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(261, 30);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(122, 43);
            this.guna2Button2.TabIndex = 55;
            this.guna2Button2.Text = "Thêm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.guna2Button2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(615, 581);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(663, 88);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Công cụ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(14, 34);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(307, 36);
            this.guna2TextBox7.TabIndex = 53;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(351, 30);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(122, 43);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guna2Button1);
            this.groupBox3.Controls.Add(this.guna2TextBox7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(75, 581);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(505, 88);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên nhân viên";
            // 
            // UC_QLXe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLXe";
            this.Size = new System.Drawing.Size(1300, 721);
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txt_NamSanXuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button capnhat_btn;
        private System.Windows.Forms.TextBox txt_TinhTang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PhanKhoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CongSuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_HangSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MauSac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TenXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LoaiXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanPhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhTrang;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa_btn;
    }
}
