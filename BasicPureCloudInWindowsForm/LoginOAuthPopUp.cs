using ININ.PureCloud.OAuthControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPureCloudInWindowsForm
{
    /// Author : Arba
    /// Description : Authentication Page as Popup Form
    public partial class LoginOAuthPopUp : Form
    {
        public string access_token;

        public LoginOAuthPopUp(string environment, string clientid, string redirect_uri)
        {
            InitializeComponent();

            LoginForm parent = new LoginForm();

            OAuthWebBrowser oAuthWebBrowser1 = new OAuthWebBrowser();
            oAuthWebBrowser1.Environment = environment;
            oAuthWebBrowser1.ClientId = clientid;
            oAuthWebBrowser1.RedirectUri = redirect_uri;

            // Handle events
            oAuthWebBrowser1.ExceptionEncountered +=
                (source, exception) =>
                {
                    Console.WriteLine($"[ERROR] {source} => {exception.Message}");
                    Console.WriteLine(exception);
                };
            oAuthWebBrowser1.Authenticated += token =>
            {
                if (!string.IsNullOrEmpty(token))
                {
                    Console.WriteLine($"Token => {token}");
                    access_token = token;

                    if (!string.IsNullOrEmpty(access_token))
                    {
                        this.DialogResult = DialogResult.OK;
                    }

                    this.Close();
                }
            };

            oAuthWebBrowser1.BeginImplicitGrant();
            
        }
        
    }
}
