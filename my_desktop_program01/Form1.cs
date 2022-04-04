using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Threading;
using Newtonsoft.Json;
using Flurl;
using Flurl.Http;

namespace my_desktop_program01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void submit_Click(object sender, EventArgs e)
        {
            PrivateUserInfo user_info = new PrivateUserInfo();
            user_info.UserName = name_box.Text;
            user_info.UserId = id_box.Text;
            user_info.UserAddr = addr_box.Text;
            user_info.UserAge = int.Parse(age_box.Text);
            user_info.UserSex = sex_box.Text;
            string json_body = Newtonsoft.Json.JsonConvert.SerializeObject(user_info);
            string text = await "https://baidu.com".GetStringAsync();
            result_text.Text = text;



        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = select_upload_file.ShowDialog();
            //result.ToString();
            result_text.Text = select_upload_file.FileName;
            //select_upload_file.
        }
    }
    public class PrivateUserInfo
    {
        public string UserName;
        public string UserId;
        public string UserAddr;
        public Int32 UserAge;
        public string UserSex;
    }
}
