using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Proje1
{
    public partial class AJANDY : Form
    {
        public AJANDY()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(T_Title.Text,T_Not.Text,Convert.ToDateTime(T_StDate.Text),Convert.ToDateTime(T_EnDate.Text),Convert.ToInt32(T_exc.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void B_Send_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
           
            smtp.Credentials = new System.Net.NetworkCredential(T_SendGmail.Text, T_Passw.Text);
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = false;

            message.Body = T_Not.Text;
            message.Subject = T_Title.Text;
            message.To.Add(T_SendGmail.Text);
            message.From = new MailAddress(T_SendGmail.Text);
            smtp.Send(message);
        }
    }
}
