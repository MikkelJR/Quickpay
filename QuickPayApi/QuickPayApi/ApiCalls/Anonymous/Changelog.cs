using RestSharp;

namespace QuickPayApi.ApiCalls.Anonymous
{
    public class Changelog
    {
        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.GET, "/changelog");

            var response = client.Execute(request);

            return response.Content;
        }
    }
}