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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xeMayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLMuaBanXeMayDataSet = new QLMuaBanXeMay.QLMuaBanXeMayDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.xeMayTableAdapter = new QLMuaBanXeMay.QLMuaBanXeMayDataSetTableAdapters.XeMayTableAdapter();
            this.Xe_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauSacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanKhoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congSuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // xeMayTableAdapter
            // 
            this.xeMayTableAdapter.ClearBeforeFill = true;
            // 
            // Xe_GridView
            // 
            this.Xe_GridView.AllowUserToAddRows = false;
            this.Xe_GridView.AllowUserToDeleteRows = false;
            this.Xe_GridView.AllowUserToResizeColumns = false;
            this.Xe_GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Xe_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Xe_GridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Xe_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Xe_GridView.ColumnHeadersHeight = 50;
            this.Xe_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Xe_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXeDataGridViewTextBoxColumn,
            this.tenXeDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.loaiXeDataGridViewTextBoxColumn,
            this.mauSacDataGridViewTextBoxColumn,
            this.phanKhoiDataGridViewTextBoxColumn,
            this.congSuatDataGridViewTextBoxColumn,
            this.hangSXDataGridViewTextBoxColumn,
            this.namSXDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.Xoa_btn,
            this.Update_btn});
            this.Xe_GridView.DataSource = this.xeMayBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Xe_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Xe_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Xe_GridView.Location = new System.Drawing.Point(71, 103);
            this.Xe_GridView.Name = "Xe_GridView";
            this.Xe_GridView.ReadOnly = true;
            this.Xe_GridView.RowHeadersVisible = false;
            this.Xe_GridView.RowHeadersWidth = 51;
            this.Xe_GridView.RowTemplate.Height = 24;
            this.Xe_GridView.Size = new System.Drawing.Size(1135, 506);
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
            this.Xe_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Xe_GridView_CellContentClick_1);
            // 
            // maXeDataGridViewTextBoxColumn
            // 
            this.maXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maXeDataGridViewTextBoxColumn.DataPropertyName = "MaXe";
            this.maXeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.maXeDataGridViewTextBoxColumn.HeaderText = "Mã Xe";
            this.maXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maXeDataGridViewTextBoxColumn.Name = "maXeDataGridViewTextBoxColumn";
            this.maXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenXeDataGridViewTextBoxColumn
            // 
            this.tenXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenXeDataGridViewTextBoxColumn.DataPropertyName = "TenXe";
            this.tenXeDataGridViewTextBoxColumn.FillWeight = 160F;
            this.tenXeDataGridViewTextBoxColumn.HeaderText = "Tên Xe";
            this.tenXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenXeDataGridViewTextBoxColumn.Name = "tenXeDataGridViewTextBoxColumn";
            this.tenXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.FillWeight = 80.58823F;
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.phanKhoiDataGridViewTextBoxColumn.HeaderText = "Phân phối";
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
            // Update_btn
            // 
            this.Update_btn.HeaderText = "";
            this.Update_btn.MinimumWidth = 6;
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.ReadOnly = true;
            this.Update_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update_btn.Text = "Cập nhật";
            this.Update_btn.UseColumnTextForButtonValue = true;
            // 
            // UC_QLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Xe_GridView);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLXe";
            this.Size = new System.Drawing.Size(1300, 721);
            ((System.ComponentModel.ISupportInitialize)(this.xeMayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xe_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource xeMayBindingSource;
        private QLMuaBanXeMayDataSet qLMuaBanXeMayDataSet;
        private QLMuaBanXeMayDataSetTableAdapters.XeMayTableAdapter xeMayTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView Xe_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauSacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanKhoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congSuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa_btn;
        private System.Windows.Forms.DataGridViewButtonColumn Update_btn;
    }
}
