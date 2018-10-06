using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPureCloudInWindowsForm
{
    public partial class PureCloudMenu : Form
    {
        
        public PureCloudMenu(string access_token, string environment)
        {
            InitializeComponent();

            GetFQDN();

            Configuration.Default.AccessToken = access_token;
            Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri($"https://api.{environment}");
            accessTokenTextBox.Text = access_token;
        }

        private void getUserDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new UsersApi();

                List<string> expand = null;

                UserMe result = api.GetUsersMe(expand);

                userResultTextbox.Text = result.ToJson();
                userIdTextbox.Text = result.Id;
                userNameTextbox.Text = result.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                var api = new TokensApi();
                api.DeleteTokensMe();
                MessageBox.Show("DeleteTokensMe Request already sent, please check by hit Get User Button");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new ConversationsApi();

                CreateCallRequest body = new CreateCallRequest();
                body.PhoneNumber = "+6285221675710";

                CreateCallResponse result = api.PostConversationsCalls(body);
                conversationIdTextBox.Text = result.ToJson();
                conversationIdTextBox.Text = result.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HangUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new ConversationsApi();
                string conversationId = conversationIdTextBox.Text;
                string participantId = "";
                MediaParticipantRequest body = new MediaParticipantRequest();
                body.State = MediaParticipantRequest.StateEnum.Disconnected;

                api.PatchConversationsCallParticipant(conversationId, participantId, body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IVRButton_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new ConversationsApi();

                string conversationId = conversationIdTextBox.Text;
                string participantId = participantIdTextbox.Text;
                CreateSecureSession body = new CreateSecureSession();
                body.FlowId = "";
                body.UserData = "<OrderID>|1000|"+conversationId+"|<Entity>";
                body.Disconnect = false;
                body.SourceParticipantId = userIdTextbox.Text; // agentId

                SecureSession result = api.PostConversationParticipantSecureivrsessions(conversationId, participantId, body);
                IVRResultTextbox.Text = result.ToJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetFQDN()
        {
            string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();
            domainName = "." + domainName;

            if (!hostName.EndsWith(domainName))
            {
                hostName += domainName;
            }

            FQDNTextbox.Text = hostName;

            // cmd c:\>echo %COMPUTERNAME%.%USERDNSDOMAIN%
        }

        private void subscibeButton_Click(object sender, EventArgs e)
        {
            var api = new NotificationsApi();

            Channel result = api.PostNotificationsChannels();
            subscribeResultTextbox.Text = result.ToJson();

            string channelId = result.Id;
            ChannelTopic body = new ChannelTopic($"v2.users.{userIdTextbox.Text}.conversations.calls");
            List<ChannelTopic> topics = new List<ChannelTopic>();

            ChannelTopicEntityListing resultListing = api.PutNotificationsChannelSubscriptions(channelId, topics);
            subscribeResultTextbox.Text += "\n\n=============================\n\n" + result.ToJson();
        }

    }
}
