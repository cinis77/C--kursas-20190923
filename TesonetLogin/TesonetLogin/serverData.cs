using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace TesonetLogin
{
    public partial class serverData : Form
    {
        private Token token;
        private HttpClient _client;

        public serverData(Token tok)
        {
            InitializeComponent();
            token = tok;
            _client = new HttpClient();
        }

        private async void serverData_Load(object sender, EventArgs e)
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.token);
            var response = await _client.GetAsync("http://playground.tesonet.lt/v1/servers");
            var responseString = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<Server[]>(responseString);
            Serveriai.Columns.Add("name", "name");
            Serveriai.Columns.Add("distance", "distance");
            foreach (var item in data)
            {
                Serveriai.Rows.Add(item.name, item.distance);
            }
            JsonSerializer ser = new JsonSerializer();

            //Serveriai.DataSource = data.ToList();
        }
    }
}