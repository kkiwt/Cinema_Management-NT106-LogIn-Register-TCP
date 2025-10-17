using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Cinema_Management
{

    public partial class GiaoDienTaiKhoanCuaToi : Form
    {
        private UserInfo CurrentUser; // Biến / Đối tượng được lưu trữ thông tin

        public GiaoDienTaiKhoanCuaToi(UserInfo User)
        {
            InitializeComponent();
            CurrentUser = User; // Lưu thông tin người dùng
        }
        

        // Sử dụng thông tin trong sự kiện Load
        private void GiaoDienTaiKhoanCuaToi_Load(object sender, EventArgs e)
        {

            UsernameLabel.Text = "Tên Tài Khoản: " + CurrentUser.Username;
            NameLabel.Text = "Họ Tên: " + CurrentUser.HoTen;
            EmailLabel.Text = "Email: " + CurrentUser.Email;
            SDTLabel.Text = "SĐT: " + CurrentUser.SDT;
            NgaySinhLabel.Text = "Ngày Sinh: " + CurrentUser.NgaySinh.ToString("dd/MM/yyyy");
            AreaLabel.Text = "Khu Vực: " + CurrentUser.KhuVuc;
            ThongTinTaiKhoan.SendToBack();

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
