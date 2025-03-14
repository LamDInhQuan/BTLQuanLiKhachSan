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
            this.components = new System.ComponentModel.Container();
            this.dgvDangky = new System.Windows.Forms.DataGridView();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaydatphong = new System.Windows.Forms.Label();
            this.lblNgaynhanphong = new System.Windows.Forms.Label();
            this.lblNgaytraphong = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnHuyDP = new System.Windows.Forms.Button();
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
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.listTimkiem = new System.Windows.Forms.ListBox();
            this.txtNdTimkiem = new System.Windows.Forms.TextBox();
            this.lblNdTimkiem = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangky)).BeginInit();
            this.gbTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDangky
            // 
            this.dgvDangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangky.Location = new System.Drawing.Point(104, 437);
            this.dgvDangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDangky.Name = "dgvDangky";
            this.dgvDangky.RowHeadersWidth = 62;
            this.dgvDangky.Size = new System.Drawing.Size(1173, 450);
            this.dgvDangky.TabIndex = 0;
            this.dgvDangky.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangky_CellContentClick);
            this.dgvDangky.SelectionChanged += new System.EventHandler(this.dgvDangky_SelectionChanged);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKH.Location = new System.Drawing.Point(100, 190);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(161, 20);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "TÊN KHÁCH HÀNG";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(100, 270);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(131, 20);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "TÊN NHÂN VIÊN";
            // 
            // lblNgaydatphong
            // 
            this.lblNgaydatphong.AutoSize = true;
            this.lblNgaydatphong.Location = new System.Drawing.Point(600, 110);
            this.lblNgaydatphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaydatphong.Name = "lblNgaydatphong";
            this.lblNgaydatphong.Size = new System.Drawing.Size(153, 20);
            this.lblNgaydatphong.TabIndex = 5;
            this.lblNgaydatphong.Text = "NGÀY ĐẶT PHÒNG";
            // 
            // lblNgaynhanphong
            // 
            this.lblNgaynhanphong.AutoSize = true;
            this.lblNgaynhanphong.Location = new System.Drawing.Point(600, 190);
            this.lblNgaynhanphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaynhanphong.Name = "lblNgaynhanphong";
            this.lblNgaynhanphong.Size = new System.Drawing.Size(166, 20);
            this.lblNgaynhanphong.TabIndex = 6;
            this.lblNgaynhanphong.Text = "NGÀY NHẬN PHÒNG";
            // 
            // lblNgaytraphong
            // 
            this.lblNgaytraphong.AutoSize = true;
            this.lblNgaytraphong.Location = new System.Drawing.Point(600, 270);
            this.lblNgaytraphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaytraphong.Name = "lblNgaytraphong";
            this.lblNgaytraphong.Size = new System.Drawing.Size(153, 20);
            this.lblNgaytraphong.TabIndex = 7;
            this.lblNgaytraphong.Text = "NGÀY TRẢ PHÒNG";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(973, 317);
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
            this.btnTimkiem.Location = new System.Drawing.Point(427, 317);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(150, 77);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnHuyDP
            // 
            this.btnHuyDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyDP.Location = new System.Drawing.Point(604, 317);
            this.btnHuyDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuyDP.Name = "btnHuyDP";
            this.btnHuyDP.Size = new System.Drawing.Size(150, 77);
            this.btnHuyDP.TabIndex = 18;
            this.btnHuyDP.Text = "HỦY ĐẶT PHÒNG";
            this.btnHuyDP.UseVisualStyleBackColor = true;
            this.btnHuyDP.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(241, 317);
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
            this.btnDat.Location = new System.Drawing.Point(59, 317);
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
            this.lblSophong.Location = new System.Drawing.Point(100, 110);
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
            this.lblDatphong.Location = new System.Drawing.Point(675, 40);
            this.lblDatphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatphong.Name = "lblDatphong";
            this.lblDatphong.Size = new System.Drawing.Size(189, 32);
            this.lblDatphong.TabIndex = 22;
            this.lblDatphong.Text = "ĐẶT PHÒNG";
            // 
            // txtMadangky
            // 
            this.txtMadangky.Location = new System.Drawing.Point(0, 0);
            this.txtMadangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMadangky.Name = "txtMadangky";
            this.txtMadangky.Size = new System.Drawing.Size(148, 26);
            this.txtMadangky.TabIndex = 23;
            // 
            // dNgaydatphong
            // 
            this.dNgaydatphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaydatphong.Location = new System.Drawing.Point(800, 100);
            this.dNgaydatphong.Name = "dNgaydatphong";
            this.dNgaydatphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaydatphong.TabIndex = 31;
            // 
            // dNgaynhanphong
            // 
            this.dNgaynhanphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaynhanphong.Location = new System.Drawing.Point(800, 180);
            this.dNgaynhanphong.Name = "dNgaynhanphong";
            this.dNgaynhanphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaynhanphong.TabIndex = 32;
            // 
            // dNgaytraphong
            // 
            this.dNgaytraphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaytraphong.Location = new System.Drawing.Point(800, 260);
            this.dNgaytraphong.Name = "dNgaytraphong";
            this.dNgaytraphong.Size = new System.Drawing.Size(200, 26);
            this.dNgaytraphong.TabIndex = 33;
            // 
            // cboMaphong
            // 
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(270, 100);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(121, 28);
            this.cboMaphong.TabIndex = 34;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(270, 180);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 28);
            this.cboMaKH.TabIndex = 35;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(270, 260);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 28);
            this.cboMaNV.TabIndex = 36;
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.listTimkiem);
            this.gbTimkiem.Controls.Add(this.txtNdTimkiem);
            this.gbTimkiem.Controls.Add(this.lblNdTimkiem);
            this.gbTimkiem.Location = new System.Drawing.Point(1150, 100);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(450, 300);
            this.gbTimkiem.TabIndex = 37;
            this.gbTimkiem.TabStop = false;
            this.gbTimkiem.Text = "TÌM KIẾM";
            // 
            // listTimkiem
            // 
            this.listTimkiem.FormattingEnabled = true;
            this.listTimkiem.ItemHeight = 20;
            this.listTimkiem.Location = new System.Drawing.Point(10, 50);
            this.listTimkiem.Name = "listTimkiem";
            this.listTimkiem.Size = new System.Drawing.Size(430, 244);
            this.listTimkiem.TabIndex = 2;
            this.listTimkiem.SelectedIndexChanged += new System.EventHandler(this.listTimkiem_SelectedIndexChanged);
            // 
            // txtNdTimkiem
            // 
            this.txtNdTimkiem.Location = new System.Drawing.Point(200, 20);
            this.txtNdTimkiem.Name = "txtNdTimkiem";
            this.txtNdTimkiem.Size = new System.Drawing.Size(240, 26);
            this.txtNdTimkiem.TabIndex = 1;
            // 
            // lblNdTimkiem
            // 
            this.lblNdTimkiem.AutoSize = true;
            this.lblNdTimkiem.Location = new System.Drawing.Point(10, 30);
            this.lblNdTimkiem.Name = "lblNdTimkiem";
            this.lblNdTimkiem.Size = new System.Drawing.Size(174, 20);
            this.lblNdTimkiem.TabIndex = 0;
            this.lblNdTimkiem.Text = "Nhập nội dung tìm kiếm";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(301, 933);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 40;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(711, 932);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker4.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1033, 931);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Xem báo cáo ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 933);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 937);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "đến ngày ";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(800, 317);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 77);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // User_DangKyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.gbTimkiem);
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
            this.Controls.Add(this.btnHuyDP);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.lblNgaytraphong);
            this.Controls.Add(this.lblNgaynhanphong);
            this.Controls.Add(this.lblNgaydatphong);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.dgvDangky);
            this.Name = "User_DangKyPhong";
            this.Size = new System.Drawing.Size(1649, 1023);
            this.Load += new System.EventHandler(this.User_DangKyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangky)).EndInit();
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btnHuyDP;
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
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.Label lblNdTimkiem;
        private System.Windows.Forms.ListBox listTimkiem;
        private System.Windows.Forms.TextBox txtNdTimkiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
    }
}
