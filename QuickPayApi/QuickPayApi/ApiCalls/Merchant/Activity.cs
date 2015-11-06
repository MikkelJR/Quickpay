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

            if (UserId != null) request.AddParameter("user_id", UserId, ParameterType.UrlSegment);
            if (TargetType != null) request.AddParameter("target_type", TargetType, ParameterType.UrlSegment);
            if (TargetId != null) request.AddParameter("target_id", TargetId, ParameterType.UrlSegment);
            if (Support) request.AddParameter("support", Support, ParameterType.UrlSegment);
            if (Page != null) request.AddParameter("", UserId, ParameterType.UrlSegment);
            if (PageSize != null) request.AddParameter("", UserId, ParameterType.UrlSegment);
            if (SortBy != null) request.AddParameter("", UserId, ParameterType.UrlSegment);
            if (SortDir != null) request.AddParameter("", UserId, ParameterType.UrlSegment);

            var response = client.Execute(request);

            return response.Content;
        }
    }
}