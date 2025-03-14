using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKhachSan.UserControlForm
{
    public partial class User_HoaDon : UserControl
    {
        private FormMain formMain;
        public User_HoaDon(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_TaoHoaDon user_QLyHoaDon = new User_TaoHoaDon();
            Panel panel = formMain.getUserFormPanel();
            panel.Controls.Clear();
            user_QLyHoaDon.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(user_QLyHoaDon);
            user_QLyHoaDon.Visible = true;
            user_QLyHoaDon.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_QLyHoaDon user_QLyHoaDon = new User_QLyHoaDon();
            Panel panel = formMain.getUserFormPanel();
            panel.Controls.Clear();
            user_QLyHoaDon.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(user_QLyHoaDon);
            user_QLyHoaDon.Visible = true;
            user_QLyHoaDon.BringToFront();
        }
    }
}
