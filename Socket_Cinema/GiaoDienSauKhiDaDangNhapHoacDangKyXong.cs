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

    public partial class GiaoDienSauKhiDaDangNhapHoacDangKyXong : Form
    {
        private UserInfo CurrentUser; // Biến lưu trữ thông tin


        public GiaoDienSauKhiDaDangNhapHoacDangKyXong(UserInfo User)
        {
            InitializeComponent();
            CurrentUser = User; // Lưu thông tin người dùng
        }

        private void GiaoDienSauKhiDaDangNhapHoacDangKyXong_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }
       
        private void TaiKhoanCuaToi_Click(object sender, EventArgs e)
        {
            GiaoDienTaiKhoanCuaToi TaiKhoanCuaToi = new GiaoDienTaiKhoanCuaToi(CurrentUser);
            this.Hide();
            TaiKhoanCuaToi.Show();
            TaiKhoanCuaToi.FormClosed += (s, args) => this.Close();
        }
    }
}
