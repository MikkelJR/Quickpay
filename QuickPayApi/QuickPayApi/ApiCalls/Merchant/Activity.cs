using RestSharp;

namespace QuickPayApi.ApiCalls.Merchant
{
    public class Activity
    {
        public int? Page;
        public int? PageSize;
        public string SortBy;
        public string SortDir; // asc, desc
        public bool Support = false;
        public int? TargetId;
        public string TargetType;
        public int? UserId;

        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.GET, "/activity");

            if (UserId != null) request.AddParameter("user_id", UserId, ParameterType.QueryString);
            if (TargetType != null) request.AddParameter("target_type", TargetType, ParameterType.QueryString);
            if (TargetId != null) request.AddParameter("target_id", TargetId, ParameterType.QueryString);
            if (Support) request.AddParameter("support", Support, ParameterType.QueryString);
            if (Page != null) request.AddParameter("", UserId, ParameterType.QueryString);
            if (PageSize != null) request.AddParameter("", UserId, ParameterType.QueryString);
            if (SortBy != null) request.AddParameter("", UserId, ParameterType.QueryString);
            if (SortDir != null) request.AddParameter("", UserId, ParameterType.QueryString);

            var response = client.Execute(request);

            return response.Content;
        }
    }
}