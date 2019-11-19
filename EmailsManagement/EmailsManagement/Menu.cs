using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Mail;

namespace EmailsManagement
{
    public partial class Menu : Form
    {
        public static string username , pass ;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            username = Form1.userName;
            pass = Form1.pass;

        }

        private void btnHopThu_Click(object sender, EventArgs e)
        {
            Form1.imap.SelectInbox();
            List<long> uids = Form1.imap.Search(Flag.Unseen);
            foreach (long uid in uids)
            {
                IMail email = new MailBuilder()
                    .CreateFromEml(Form1.imap.GetMessageByUID(uid));
                listBoxHopThu.Items.Add(email.Subject);
            }
            Form1.imap.Close();
        }

        private void btnSoanThuMoi_Click(object sender, EventArgs e)
        {
            new ThuMoi().Show();
        }

        
    }
}
