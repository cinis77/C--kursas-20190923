using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HttpUzklausa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetTokent();
            while (true)
            {
            }
        }

        private static async void GetTokent()
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> _contentValue = new Dictionary<string, string>();
            _contentValue.Add("username", "tesonet");
            _contentValue.Add("password", "partyanimal");
            var content = new FormUrlEncodedContent(_contentValue);
            var response = await client.PostAsync("http://playground.tesonet.lt/v1/tokens", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(responseString);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.token);
            var serverResponse = await client.GetAsync("http://playground.tesonet.lt/v1/servers");
            var serverResponseString = await serverResponse.Content.ReadAsStringAsync();
            string stop;
            stop = "";
        }
    }

    internal class Token
    {
        public string token;
    }
}