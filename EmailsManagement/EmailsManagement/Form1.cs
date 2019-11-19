using System;
using System.Windows.Forms;
using Limilabs.Client.IMAP;


namespace EmailsManagement
{
    public partial class Form1 : Form
    {
        public static string userName, pass;
        public static Imap imap;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                imap = new Imap();
                imap.ConnectSSL("imap.gmail.com", 993);
                imap.Login(txtTaiKhoan.Text, txtMatKhau.Text);
                userName = txtTaiKhoan.Text;
                pass = txtMatKhau.Text;
                this.Hide();
                new Menu().Show();
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
            }
        }
    }
}
