
using BTL_QuanLiKhachSan.Resources;
using BTL_QuanLiKhachSan.UserControlForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            FormUserControl.Controls.Clear();
            FormUserControl.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void updateCheckGunaButton(Guna2Button guna2Button, UserControl userControl)
        {
            btnPhong.Checked = false;
            btnDichVu.Checked = false;
            btnNhanVien.Checked = false;
            btnKhachHang.Checked = false;
            btnHoaDon.Checked = false;
            btnDoanhThu.Checked = false;
            guna2Button.Checked = true;
            addUserControl(userControl);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            User_Phong formPhong = new User_Phong();
            updateCheckGunaButton(btnPhong, formPhong);
            iconPhong.BackColor = Color.LightSteelBlue;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            User_KhachHang formKhachHang = new User_KhachHang();
            updateCheckGunaButton(btnKhachHang, formKhachHang);
            iconKhachHang.BackColor = Color.LightSteelBlue;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            User_NhanVien formNhanVien = new User_NhanVien();
            updateCheckGunaButton(btnNhanVien, formNhanVien);
            iconNhanVien.BackColor = Color.LightSteelBlue;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            User_DichVu formDichVu = new User_DichVu();
            updateCheckGunaButton(btnDichVu, formDichVu);
            iconDichVu.BackColor = Color.LightSteelBlue;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            User_HoaDon formHoaDon = new User_HoaDon();
            updateCheckGunaButton(btnHoaDon, formHoaDon);
            iconHoaDon.BackColor = Color.LightSteelBlue;

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            User_DoanhThu formDoanhThu = new User_DoanhThu();
            updateCheckGunaButton(btnDoanhThu, formDoanhThu);
            iconDoanhThu.BackColor = Color.LightSteelBlue;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // hover cho btnDoanhThu
        private void btnDoanhThu_MouseLeave(object sender, EventArgs e)
        {
            iconDoanhThu.BackColor = Color.CornflowerBlue;
            btnDoanhThu.Checked = false;
        }


        private void iconDoanhThu_MouseEnter(object sender, EventArgs e)
        {
            iconDoanhThu.BackColor = Color.CornflowerBlue;
        }

        private void btnDoanhThu_MouseEnter(object sender, EventArgs e)
        {
            iconDoanhThu.BackColor = Color.LightSteelBlue;
        }

        // hover cho btnHoaDon 
        private void iconHoaDon_MouseEnter(object sender, EventArgs e)
        {
            iconHoaDon.BackColor = Color.CornflowerBlue;
        }

        private void btnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            iconHoaDon.BackColor = Color.CornflowerBlue;
            btnHoaDon.Checked = false;
        }

        private void btnHoaDon_MouseEnter_1(object sender, EventArgs e)
        {
            iconHoaDon.BackColor = Color.LightSteelBlue;
        }

        // hover cho btnKhachHang 
        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            iconKhachHang.BackColor = Color.LightSteelBlue;
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            iconKhachHang.BackColor = Color.CornflowerBlue;
            btnKhachHang.Checked = false;
        }

        private void iconKhachHang_MouseEnter(object sender, EventArgs e)
        {
            iconKhachHang.BackColor = Color.CornflowerBlue;
        }


        // hover cho btnNhanVien 
        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            iconNhanVien.BackColor = Color.LightSteelBlue;
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            iconNhanVien.BackColor = Color.CornflowerBlue;
            btnNhanVien.Checked = false;
        }

        private void iconNhanVien_MouseEnter(object sender, EventArgs e)
        {
            iconNhanVien.BackColor = Color.CornflowerBlue;
        }

        // hover cho btnDichVu 
        private void btnDichVu_MouseEnter(object sender, EventArgs e)
        {
            iconDichVu.BackColor = Color.LightSteelBlue;
        }

        private void btnDichVu_MouseLeave(object sender, EventArgs e)
        {
            iconDichVu.BackColor = Color.CornflowerBlue;
            btnDichVu.Checked = false;
        }


        private void iconDichVu_MouseEnter(object sender, EventArgs e)
        {
            iconDichVu.BackColor = Color.CornflowerBlue;
        }

        // hover cho btnPhong 
        private void btnPhong_MouseEnter(object sender, EventArgs e)
        {
            iconPhong.BackColor = Color.LightSteelBlue;
        }

        private void btnPhong_MouseLeave(object sender, EventArgs e)
        {
            iconPhong.BackColor = Color.CornflowerBlue;
            btnPhong.Checked = false;
        }

        private void iconPhong_MouseEnter(object sender, EventArgs e)
        {
            iconPhong.BackColor = Color.CornflowerBlue;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
        // xử lí btnMenu
        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.LightSteelBlue;
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.LightSteelBlue;
        }

        // xử lí hover btnDangXua
        private void btnDangXuat_MouseEnter(object sender, EventArgs e)
        {
            iconDangXuat.BackColor = Color.LightSteelBlue;
        }

        private void btnDangXuat_MouseLeave(object sender, EventArgs e)
        {
            iconDangXuat.BackColor = Color.CornflowerBlue;
            btnDangXuat.Checked = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            iconDangXuat.BackColor = Color.CornflowerBlue;
        }
    }
}
