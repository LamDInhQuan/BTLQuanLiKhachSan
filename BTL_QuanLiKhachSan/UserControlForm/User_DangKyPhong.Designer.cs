namespace BTL_QuanLiKhachSan.UserControlForm
{
    partial class User_DangKyPhong
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
            this.dgvDangky = new System.Windows.Forms.DataGridView();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaydatphong = new System.Windows.Forms.Label();
            this.lblNgaynhanphong = new System.Windows.Forms.Label();
            this.lblNgaytraphong = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnDat = new System.Windows.Forms.Button();
            this.lblSophong = new System.Windows.Forms.Label();
            this.lblDatphong = new System.Windows.Forms.Label();
            this.txtMadangky = new System.Windows.Forms.TextBox();
            this.dNgaydatphong = new System.Windows.Forms.DateTimePicker();
            this.dNgaynhanphong = new System.Windows.Forms.DateTimePicker();
            this.dNgaytraphong = new System.Windows.Forms.DateTimePicker();
            this.cboMaphong = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDangky
            // 
            this.dgvDangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangky.Location = new System.Drawing.Point(150, 615);
            this.dgvDangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDangky.Name = "dgvDangky";
            this.dgvDangky.RowHeadersWidth = 62;
            this.dgvDangky.Size = new System.Drawing.Size(1173, 450);
            this.dgvDangky.TabIndex = 0;
            this.dgvDangky.SelectionChanged += new System.EventHandler(this.dgvDangky_SelectionChanged);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKH.Location = new System.Drawing.Point(150, 230);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(161, 20);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "TÊN KHÁCH HÀNG";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(150, 310);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(131, 20);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "TÊN NHÂN VIÊN";
            // 
            // lblNgaydatphong
            // 
            this.lblNgaydatphong.AutoSize = true;
            this.lblNgaydatphong.Location = new System.Drawing.Point(900, 150);
            this.lblNgaydatphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaydatphong.Name = "lblNgaydatphong";
            this.lblNgaydatphong.Size = new System.Drawing.Size(153, 20);
            this.lblNgaydatphong.TabIndex = 5;
            this.lblNgaydatphong.Text = "NGÀY ĐẶT PHÒNG";
            // 
            // lblNgaynhanphong
            // 
            this.lblNgaynhanphong.AutoSize = true;
            this.lblNgaynhanphong.Location = new System.Drawing.Point(900, 230);
            this.lblNgaynhanphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaynhanphong.Name = "lblNgaynhanphong";
            this.lblNgaynhanphong.Size = new System.Drawing.Size(166, 20);
            this.lblNgaynhanphong.TabIndex = 6;
            this.lblNgaynhanphong.Text = "NGÀY NHẬN PHÒNG";
            // 
            // lblNgaytraphong
            // 
            this.lblNgaytraphong.AutoSize = true;
            this.lblNgaytraphong.Location = new System.Drawing.Point(900, 310);
            this.lblNgaytraphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaytraphong.Name = "lblNgaytraphong";
            this.lblNgaytraphong.Size = new System.Drawing.Size(153, 20);
            this.lblNgaytraphong.TabIndex = 7;
            this.lblNgaytraphong.Text = "NGÀY TRẢ PHÒNG";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(1275, 462);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 77);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Location = new System.Drawing.Point(975, 462);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(150, 77);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(675, 462);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 77);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(383, 462);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(150, 77);
            this.btnNhan.TabIndex = 17;
            this.btnNhan.Text = "NHẬN PHÒNG";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnDat
            // 
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDat.Location = new System.Drawing.Point(75, 462);
            this.btnDat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(150, 77);
            this.btnDat.TabIndex = 16;
            this.btnDat.Text = "ĐẶT PHÒNG";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Location = new System.Drawing.Point(150, 150);
            this.lblSophong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(94, 20);
            this.lblSophong.TabIndex = 21;
            this.lblSophong.Text = "SỐ PHÒNG";
            // 
            // lblDatphong
            // 
            this.lblDatphong.AutoSize = true;
            this.lblDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDatphong.Location = new System.Drawing.Point(675, 46);
            this.lblDatphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatphong.Name = "lblDatphong";
            this.lblDatphong.Size = new System.Drawing.Size(189, 32);
            this.lblDatphong.TabIndex = 22;
            this.lblDatphong.Text = "ĐẶT PHÒNG";
            // 
            // txtMadangky
            // 
            this.txtMadangky.Location = new System.Drawing.Point(1187, 0);
            this.txtMadangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMadangky.Name = "txtMadangky";
            this.txtMadangky.Size = new System.Drawing.Size(148, 26);
            this.txtMadangky.TabIndex = 23;
            // 
            // dNgaydatphong
            // 
            this.dNgaydatphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaydatphong.Location = new System.Drawing.Point(1100, 140);
            this.dNgaydatphong.Name = "dNgaydatphong";
            this.dNgaydatphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaydatphong.TabIndex = 31;
            // 
            // dNgaynhanphong
            // 
            this.dNgaynhanphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaynhanphong.Location = new System.Drawing.Point(1100, 220);
            this.dNgaynhanphong.Name = "dNgaynhanphong";
            this.dNgaynhanphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaynhanphong.TabIndex = 32;
            // 
            // dNgaytraphong
            // 
            this.dNgaytraphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaytraphong.Location = new System.Drawing.Point(1100, 300);
            this.dNgaytraphong.Name = "dNgaytraphong";
            this.dNgaytraphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaytraphong.TabIndex = 33;
            // 
            // cboMaphong
            // 
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(320, 140);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(121, 28);
            this.cboMaphong.TabIndex = 34;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(320, 220);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 28);
            this.cboMaKH.TabIndex = 35;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(320, 300);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 28);
            this.cboMaNV.TabIndex = 36;
            // 
            // User_DangKyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.cboMaphong);
            this.Controls.Add(this.dNgaytraphong);
            this.Controls.Add(this.dNgaynhanphong);
            this.Controls.Add(this.dNgaydatphong);
            this.Controls.Add(this.txtMadangky);
            this.Controls.Add(this.lblDatphong);
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.lblNgaytraphong);
            this.Controls.Add(this.lblNgaynhanphong);
            this.Controls.Add(this.lblNgaydatphong);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.dgvDangky);
            this.Name = "User_DangKyPhong";
            this.Size = new System.Drawing.Size(1335, 1023);
            this.Load += new System.EventHandler(this.User_DangKyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDangky;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblNgaydatphong;
        private System.Windows.Forms.Label lblNgaynhanphong;
        private System.Windows.Forms.Label lblNgaytraphong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label lblDatphong;
        private System.Windows.Forms.TextBox txtMadangky;
        private System.Windows.Forms.DateTimePicker dNgaydatphong;
        private System.Windows.Forms.DateTimePicker dNgaynhanphong;
        private System.Windows.Forms.DateTimePicker dNgaytraphong;
        private System.Windows.Forms.ComboBox cboMaphong;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
    }
}
