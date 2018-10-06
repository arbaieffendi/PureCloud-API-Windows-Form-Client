using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPureCloudInWindowsForm
{
    /// Author : Arba
    /// Description : Authentication Page
    public partial class LoginForm : Form
    {
        public string environment = "mypurecloud.jp";
        public string clientid = "87c48ac3-b31a-4faa-ae6f-06f4d0245004";
        public string redirect_uri = "https://121219201303.ip-dynamic.com/axitswebapi/OAuth/Callback";

        public LoginForm()
        {
            InitializeComponent();

            URLTextbox.Text =
                $"https:\\\\login.{environment}\\oauth\\authorize?client_id={clientid}&response_type=token&redirect_uri={redirect_uri}";
        }
        
        private void getAccessTokenButton_Click_1(object sender, EventArgs e)
        {
            urlHashTextbox.Text = webBrowser1.Url.Fragment;

            try
            {
                string[] temp1 = webBrowser1.Url.Fragment.Split('#');
                string[] temp2 = temp1[1].Split('&');

                for (int i = 0; i < temp2.Length; i++)
                {
                    if (temp2[i].Contains("access_token"))
                    {
                        string[] temp3 = temp2[i].Split('=');
                        accessTokenTextbox.Text = temp3[1].ToString();
                        return;
                    }
                    else
                    {
                        accessTokenTextbox.Text = "Access_Token is not available. Please contact IT support. Thanks";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please report this to IT support. Exception : " + ex.Message);
            }
        }

        private void processURLAboveButton_Click(object sender, EventArgs e)
        {
            urlHashTextbox.Text = null;
            accessTokenTextbox.Text = null;
            webBrowser1.Navigate(URLTextbox.Text);
        }

        private void popUpLoginButton_Click(object sender, EventArgs e)
        {
            urlHashTextbox.Text = null;
            using (LoginOAuthPopUp loginOAuthPopUp = new LoginOAuthPopUp(environment, clientid, redirect_uri))
            {
                if (loginOAuthPopUp.ShowDialog() == DialogResult.OK)
                {
                    accessTokenTextbox.Text = loginOAuthPopUp.access_token;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            PureCloudMenu menu = new PureCloudMenu(accessTokenTextbox.Text, environment);
            menu.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            urlHashTextbox.Text = null;
            accessTokenTextbox.Text = null;
            webBrowser1.Navigate(
                $"https://login.{environment}/logout"
                );
        }
    }
}
