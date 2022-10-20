using System.Configuration;
using System.Net;

namespace ConsoleApp2
{
    public static class DownloadFileLogic
    {

        static readonly HttpClient client = new HttpClient();
        public static async Task Main() 
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(ConfigurationManager.AppSettings["FileLocation"]);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        public static void DownloadFile()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(ConfigurationManager.AppSettings["FileLocation"], ConfigurationManager.AppSettings["FileDestination"]);
        }
    }
}
