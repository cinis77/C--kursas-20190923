using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft;

namespace TesonetLogin
{
    public partial class Form1 : Form
    {
        private HttpClient _client;

        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UserNameText.Text) || string.IsNullOrEmpty(PasswordText.Text))
                {
                    throw new FormatException();
                }
                Dictionary<string, string> _content = new Dictionary<string, string>();
                _content.Add("username", UserNameText.Text);
                _content.Add("password", PasswordText.Text);
                var content = new FormUrlEncodedContent(_content);

                var response = await _client.PostAsync("http://playground.tesonet.lt/v1/tokens", content);
                var responseString = await response.Content.ReadAsStringAsync();
                var message = JsonConvert.DeserializeObject<RequestError>(responseString);
                if (message.message != null)
                {
                    throw new JsonException(message: "Gauta klaida is Http uzklausos");
                }
                var token = JsonConvert.DeserializeObject<Token>(responseString);
                serverData server = new serverData(token);
                server.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nesuvesti visi duomenys");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Problema su internetu");
            }
            catch (JsonException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}