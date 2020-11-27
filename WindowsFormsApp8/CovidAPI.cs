using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class CovidAPI
    {
        public CovidAPI()
        {

        }

        public async Task<int> ReturnDeaths(string country)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total?country=" + country),
                Headers =
    {
        { "x-rapidapi-key", "enter your own key" },
        { "x-rapidapi-host", "enter your own host" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                Console.WriteLine("**********************************");
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //richTextBox1.Text = body;
                var MyData = JsonConvert.DeserializeObject<RootCovid>(body);

                return MyData.data.deaths;
            }
        }
    }
}
