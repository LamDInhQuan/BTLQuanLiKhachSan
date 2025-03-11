namespace BTL_QuanLiKhachSan.UserControlForm
{
    partial class User_KhachHang
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
<<<<<<< Updated upstream
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
=======
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnHoten = new System.Windows.Forms.RadioButton();
            this.rbtnCMND = new System.Windows.Forms.RadioButton();
            this.rbtnSDT = new System.Windows.Forms.RadioButton();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.gbTimkiem.SuspendLayout();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // dgvKH
            // 
<<<<<<< Updated upstream
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 314);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng";
=======
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(150, 600);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 62;
            this.dgvKH.RowTemplate.Height = 28;
            this.dgvKH.Size = new System.Drawing.Size(1322, 400);
            this.dgvKH.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(1300, 450);
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
            this.btnTimkiem.Location = new System.Drawing.Point(1000, 450);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(150, 77);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(700, 450);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 77);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(400, 450);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 77);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(100, 450);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 77);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(300, 150);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(148, 26);
            this.txtCMND.TabIndex = 26;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(650, 100);
            this.lblGioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(85, 20);
            this.lblGioitinh.TabIndex = 25;
            this.lblGioitinh.Text = "GIỚI TÍNH";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(150, 160);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(56, 20);
            this.lblCMND.TabIndex = 23;
            this.lblCMND.Text = "CMND";
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(300, 90);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(148, 26);
            this.txtHoten.TabIndex = 22;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(150, 100);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(68, 20);
            this.lblHoten.TabIndex = 21;
            this.lblHoten.Text = "HỌ TÊN";
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachhang.Location = new System.Drawing.Point(400, 20);
            this.lblKhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(356, 32);
            this.lblKhachhang.TabIndex = 29;
            this.lblKhachhang.Text = " QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Enabled = false;
            this.txtGhichu.Location = new System.Drawing.Point(800, 210);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(148, 26);
            this.txtGhichu.TabIndex = 33;
            // 
            // lblGhichu
            // 
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Location = new System.Drawing.Point(650, 220);
            this.lblGhichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(78, 20);
            this.lblGhichu.TabIndex = 32;
            this.lblGhichu.Text = "GHI CHÚ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Location = new System.Drawing.Point(300, 210);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(148, 26);
            this.txtDiachi.TabIndex = 31;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(150, 220);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(73, 20);
            this.lblDiachi.TabIndex = 30;
            this.lblDiachi.Text = "ĐỊA CHỈ ";
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgaysinh.Location = new System.Drawing.Point(800, 150);
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.Size = new System.Drawing.Size(200, 26);
            this.dNgaysinh.TabIndex = 37;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(650, 160);
            this.lblNgaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(98, 20);
            this.lblNgaysinh.TabIndex = 34;
            this.lblNgaysinh.Text = "NGÀY SINH";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(300, 270);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 26);
            this.txtSDT.TabIndex = 39;
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Location = new System.Drawing.Point(150, 280);
            this.lblSodienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(128, 20);
            this.lblSodienthoai.TabIndex = 38;
            this.lblSodienthoai.Text = "SỐ ĐIỆN THOẠI";
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.rbtnSDT);
            this.gbTimkiem.Controls.Add(this.rbtnCMND);
            this.gbTimkiem.Controls.Add(this.rbtnHoten);
            this.gbTimkiem.Location = new System.Drawing.Point(1100, 100);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(250, 250);
            this.gbTimkiem.TabIndex = 40;
            this.gbTimkiem.TabStop = false;
            this.gbTimkiem.Text = "TÌM KIẾM";
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(800, 90);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(67, 24);
            this.rbtnNam.TabIndex = 41;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(900, 90);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(54, 24);
            this.rbtnNu.TabIndex = 42;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnHoten
            // 
            this.rbtnHoten.AutoSize = true;
            this.rbtnHoten.Location = new System.Drawing.Point(10, 50);
            this.rbtnHoten.Name = "rbtnHoten";
            this.rbtnHoten.Size = new System.Drawing.Size(82, 24);
            this.rbtnHoten.TabIndex = 0;
            this.rbtnHoten.TabStop = true;
            this.rbtnHoten.Text = "Họ tên";
            this.rbtnHoten.UseVisualStyleBackColor = true;
            this.rbtnHoten.CheckedChanged += new System.EventHandler(this.rbtnHoten_CheckedChanged);
            // 
            // rbtnCMND
            // 
            this.rbtnCMND.AutoSize = true;
            this.rbtnCMND.Location = new System.Drawing.Point(10, 100);
            this.rbtnCMND.Name = "rbtnCMND";
            this.rbtnCMND.Size = new System.Drawing.Size(81, 24);
            this.rbtnCMND.TabIndex = 1;
            this.rbtnCMND.TabStop = true;
            this.rbtnCMND.Text = "CMND";
            this.rbtnCMND.UseVisualStyleBackColor = true;
            this.rbtnCMND.CheckedChanged += new System.EventHandler(this.rbtnCMND_CheckedChanged);
            // 
            // rbtnSDT
            // 
            this.rbtnSDT.AutoSize = true;
            this.rbtnSDT.Location = new System.Drawing.Point(10, 150);
            this.rbtnSDT.Name = "rbtnSDT";
            this.rbtnSDT.Size = new System.Drawing.Size(127, 24);
            this.rbtnSDT.TabIndex = 2;
            this.rbtnSDT.TabStop = true;
            this.rbtnSDT.Text = "Số điện thoại";
            this.rbtnSDT.UseVisualStyleBackColor = true;
            this.rbtnSDT.CheckedChanged += new System.EventHandler(this.rbtnSDT_CheckedChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(899, 25);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 26);
            this.txtMaKH.TabIndex = 43;
>>>>>>> Stashed changes
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "User_KhachHang";
            this.Size = new System.Drawing.Size(1342, 1022);
=======
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.gbTimkiem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSodienthoai);
            this.Controls.Add(this.dNgaysinh);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.lblGhichu);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblKhachhang);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKH);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "User_KhachHang";
            this.Size = new System.Drawing.Size(1342, 1022);
            this.Load += new System.EventHandler(this.User_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< Updated upstream
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblKhachhang;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DateTimePicker dNgaysinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSodienthoai;
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnHoten;
        private System.Windows.Forms.RadioButton rbtnSDT;
        private System.Windows.Forms.RadioButton rbtnCMND;
        private System.Windows.Forms.TextBox txtMaKH;
>>>>>>> Stashed changes
    }
}
