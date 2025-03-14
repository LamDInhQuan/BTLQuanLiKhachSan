namespace BTL_QuanLiKhachSan.UserControlForm
{
    partial class User_Phong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lblMaphong = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.lblSophong = new System.Windows.Forms.Label();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblLoaiphong = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.rbtnSoPhong = new System.Windows.Forms.RadioButton();
            this.rbtnLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rbtnTrangThai = new System.Windows.Forms.RadioButton();
            this.gbTimkiem = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.gbTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(300, 462);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.ShowRowErrors = false;
            this.dgvPhong.Size = new System.Drawing.Size(840, 557);
            this.dgvPhong.TabIndex = 0;
            // 
            // lblMaphong
            // 
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaphong.Location = new System.Drawing.Point(650, 50);
            this.lblMaphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(268, 32);
            this.lblMaphong.TabIndex = 1;
            this.lblMaphong.Text = " QUẢN LÝ PHÒNG";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(1189, 0);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(148, 26);
            this.txtMaphong.TabIndex = 2;
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Location = new System.Drawing.Point(150, 154);
            this.lblSophong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(94, 20);
            this.lblSophong.TabIndex = 3;
            this.lblSophong.Text = "SỐ PHÒNG";
            // 
            // txtSophong
            // 
            this.txtSophong.Enabled = false;
            this.txtSophong.Location = new System.Drawing.Point(255, 143);
            this.txtSophong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(148, 26);
            this.txtSophong.TabIndex = 4;
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(150, 231);
            this.lblDongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(77, 20);
            this.lblDongia.TabIndex = 5;
            this.lblDongia.Text = "ĐƠN GIÁ";
            // 
            // lblLoaiphong
            // 
            this.lblLoaiphong.AutoSize = true;
            this.lblLoaiphong.Location = new System.Drawing.Point(900, 154);
            this.lblLoaiphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiphong.Name = "lblLoaiphong";
            this.lblLoaiphong.Size = new System.Drawing.Size(108, 20);
            this.lblLoaiphong.TabIndex = 6;
            this.lblLoaiphong.Text = "LOẠI PHÒNG";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Location = new System.Drawing.Point(900, 231);
            this.lblTrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(106, 20);
            this.lblTrangthai.TabIndex = 7;
            this.lblTrangthai.Text = "TRẠNG THÁI";
            // 
            // txtDongia
            // 
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(255, 220);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(148, 26);
            this.txtDongia.TabIndex = 8;
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.Enabled = false;
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Location = new System.Drawing.Point(1018, 142);
            this.cboLoaiphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(180, 28);
            this.cboLoaiphong.TabIndex = 9;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.Enabled = false;
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(1018, 218);
            this.cboTrangthai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(180, 28);
            this.cboTrangthai.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(124, 308);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 77);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(321, 308);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 77);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.Location = new System.Drawing.Point(822, 308);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(150, 77);
            this.btnBaoCao.TabIndex = 13;
            this.btnBaoCao.Text = "IN BÁO CÁO";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Location = new System.Drawing.Point(598, 308);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(150, 77);
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(1033, 308);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 77);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // rbtnSoPhong
            // 
            this.rbtnSoPhong.AutoSize = true;
            this.rbtnSoPhong.Location = new System.Drawing.Point(30, 50);
            this.rbtnSoPhong.Name = "rbtnSoPhong";
            this.rbtnSoPhong.Size = new System.Drawing.Size(107, 24);
            this.rbtnSoPhong.TabIndex = 16;
            this.rbtnSoPhong.TabStop = true;
            this.rbtnSoPhong.Text = "Số phòng ";
            this.rbtnSoPhong.UseVisualStyleBackColor = true;
            this.rbtnSoPhong.CheckedChanged += new System.EventHandler(this.rbtnSoPhong_CheckedChanged);
            // 
            // rbtnLoaiPhong
            // 
            this.rbtnLoaiPhong.AutoSize = true;
            this.rbtnLoaiPhong.Location = new System.Drawing.Point(30, 100);
            this.rbtnLoaiPhong.Name = "rbtnLoaiPhong";
            this.rbtnLoaiPhong.Size = new System.Drawing.Size(113, 24);
            this.rbtnLoaiPhong.TabIndex = 18;
            this.rbtnLoaiPhong.TabStop = true;
            this.rbtnLoaiPhong.Text = "Loại phòng";
            this.rbtnLoaiPhong.UseVisualStyleBackColor = true;
            this.rbtnLoaiPhong.CheckedChanged += new System.EventHandler(this.rbtnLoaiPhong_CheckedChanged);
            // 
            // rbtnTrangThai
            // 
            this.rbtnTrangThai.AutoSize = true;
            this.rbtnTrangThai.Location = new System.Drawing.Point(30, 150);
            this.rbtnTrangThai.Name = "rbtnTrangThai";
            this.rbtnTrangThai.Size = new System.Drawing.Size(105, 24);
            this.rbtnTrangThai.TabIndex = 19;
            this.rbtnTrangThai.TabStop = true;
            this.rbtnTrangThai.Text = "Trạng thái";
            this.rbtnTrangThai.UseVisualStyleBackColor = true;
            this.rbtnTrangThai.CheckedChanged += new System.EventHandler(this.rbtnTrangThai_CheckedChanged);
            // 
            // gbTimkiem
            // 
            this.gbTimkiem.Controls.Add(this.rbtnTrangThai);
            this.gbTimkiem.Controls.Add(this.rbtnSoPhong);
            this.gbTimkiem.Controls.Add(this.rbtnLoaiPhong);
            this.gbTimkiem.Location = new System.Drawing.Point(1200, 500);
            this.gbTimkiem.Name = "gbTimkiem";
            this.gbTimkiem.Size = new System.Drawing.Size(200, 230);
            this.gbTimkiem.TabIndex = 20;
            this.gbTimkiem.TabStop = false;
            this.gbTimkiem.Text = "Tìm kiếm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(1210, 308);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 77);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // User_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gbTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.cboLoaiphong);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.lblTrangthai);
            this.Controls.Add(this.lblLoaiphong);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.txtSophong);
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.lblMaphong);
            this.Controls.Add(this.dgvPhong);
            this.Name = "User_Phong";
            this.Size = new System.Drawing.Size(1335, 1011);
            this.Load += new System.EventHandler(this.User_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.gbTimkiem.ResumeLayout(false);
            this.gbTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblMaphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblLoaiphong;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.RadioButton rbtnSoPhong;
        private System.Windows.Forms.RadioButton rbtnLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnTrangThai;
        private System.Windows.Forms.GroupBox gbTimkiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHuy;
    }
}
