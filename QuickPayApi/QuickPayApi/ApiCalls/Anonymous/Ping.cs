using RestSharp;

namespace QuickPayApi.ApiCalls.Anonymous
{
    public class Ping
    {
        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.GET, "/ping");

            var response = client.Execute(request);

            return response.Content;
        }
    }
}