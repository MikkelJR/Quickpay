using RestSharp;

namespace QuickPayApi.ApiCalls.Merchant
{
    public class Cancel
    {
        public string PaymentId;

        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.POST, $"/payments/{PaymentId}/capture");

            var response = client.Execute(request);

            return response.Content;
        }
    }
}