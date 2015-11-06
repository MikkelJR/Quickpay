using RestSharp;

namespace QuickPayApi.ApiCalls.Merchant
{
    public class Capture
    {
        public int Amount;
        public string PaymentId;
        public string TextOnStatement;

        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.POST, $"/payments/{PaymentId}/capture");

            request.AddParameter("amount", Amount.ToString());
            request.AddParameter("text_on_statement", TextOnStatement);

            var response = client.Execute(request);

            return response.Content;
        }
    }
}