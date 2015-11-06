using System;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace QuickPayApi.ApiCalls
{
    public class ProcessRequest
    {
        public static RestClient CreateRestClient()
        {
            return new RestClient
            {
                BaseUrl = new Uri(Constants.ApiBaseUrl),
                PreAuthenticate = false,
                Authenticator = new HttpBasicAuthenticator("", Constants.Keys.Api)
            };
        }

        public static RestRequest CreateRequest(Method method, string resource, DataFormat format = DataFormat.Json)
        {
            var request = new RestRequest
            {
                Resource = resource,
                Method = method,
                RequestFormat = format
            };

            var basicAuthCred = Convert.ToBase64String(Encoding.Default.GetBytes($":{Constants.Keys.Api}"));
            request.AddHeader("Authorization", $"Basic {basicAuthCred}");
            request.AddHeader("Accept-Version", Constants.ApiVersionHeader);

            return request;
        }
    }
}