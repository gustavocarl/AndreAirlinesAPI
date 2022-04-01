using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AndreAirlinesAPI.Services
{
    public class APICorreios
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task RequisitarServico()
        {
            try
            {

                HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/01001000/json/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message -> " + e.Message);
            }

        }
    }
}
