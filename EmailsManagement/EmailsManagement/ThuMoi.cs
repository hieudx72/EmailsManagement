using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailsManagement
{
    public partial class ThuMoi : Form
    {
        private string username = Form1.userName, pass = Form1.pass ;
        public ThuMoi()
        {
            InitializeComponent();
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in dialog.FileNames)
                {    
                    listBoxDinhkem.Items.Add(filename.ToString());
                }
            }
        
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            GuiMail(username, txtTo.Text, txtSuject.Text, txtMessage.Text);
            MessageBox.Show("Đã gửi !");
            this.Hide();
        }

        void GuiMail(string emailfrom, string emailto, string suject, string message)
        {
            MailMessage mess = new MailMessage(emailfrom, emailto, suject, message);
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential(username, pass);

            //Kiểm tra đính kèm
            if (listBoxDinhkem.Items.Count > 0)
            {
                foreach (var filename in listBoxDinhkem.Items)
                {
                    //Kiểm tra file có tồn tại trong ổ đĩa không
                    if (File.Exists(filename.ToString()))
                    {
                        //Thêm file đính kèm vào tin nhắn
                        mess.Attachments.Add(new Attachment(filename.ToString()));
                    }
                }
            }

            sc.Send(mess);
        }
    }
}
