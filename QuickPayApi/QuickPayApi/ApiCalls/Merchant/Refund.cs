using RestSharp;

namespace QuickPayApi.ApiCalls.Merchant
{
    public class Refund
    {
        public int Amount;
        public string PaymentId;
        public string TextOnStatement;

        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.POST, $"/payments/{PaymentId}/refund");

            request.AddParameter("amount", Amount.ToString());

            var response = client.Execute(request);

            return response.Content;
        }
    }
}