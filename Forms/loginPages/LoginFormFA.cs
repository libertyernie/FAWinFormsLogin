using FAWinFormsLogin.Sites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWinFormsLogin.loginPages
{

    public partial class LoginFormFA : Form
    {
        public string Cookies = null;
        private FurAffinity _fa;
        public LoginFormFA()
        {
            _fa = new FurAffinity();
            InitializeComponent();
        }

        private async void LoginFormFA_Load(object sender, EventArgs e) {
            try
            {
                captcha_PicBox.Image = await _fa.GetCaptchaAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Could not load captcha: " + ex.Message, ex.GetType().Name);
            }
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cookie = await _fa.loginAsync(username_TxtBox.Text, password_TxtBox.Text, captcha_TxtBox.Text);
                if (cookie != null)
                {
                    Cookies = cookie;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                MessageBox.Show("Login Failed");
                captcha_PicBox.Image = await _fa.GetCaptchaAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occured: " + ex.Message, ex.GetType().Name);
            }
        }
    }
}
