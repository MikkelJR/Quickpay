using RestSharp;

namespace QuickPayApi.ApiCalls.Merchant
{
    public class Payments
    {
        public bool Accepted = false;
        public int? DateDay;
        public int? DateHour;
        public int? DateMinute;
        public int? DateMonth;
        public int? DateYear;
        public int? Id;
        public string OrderId;
        public int? Page;
        public int? PageSize;
        public string SortBy; // id, order_id
        public string SortDir; // asc, desc
        public string State; // initial, pending, new, rejected, processed

        public string Execute()
        {
            var client = ProcessRequest.CreateRestClient();
            var request = ProcessRequest.CreateRequest(Method.GET, "/payments");

            if (DateYear != null) request.AddParameter("date[year]", DateYear, ParameterType.UrlSegment);
            if (DateMonth != null) request.AddParameter("date[month]", DateMonth, ParameterType.UrlSegment);
            if (DateDay != null) request.AddParameter("date[day]", DateDay, ParameterType.UrlSegment);
            if (DateHour != null) request.AddParameter("date[hour]", DateHour, ParameterType.UrlSegment);
            if (DateMinute != null) request.AddParameter("date[minute]", DateMinute, ParameterType.UrlSegment);
            if (Accepted) request.AddParameter("accepted", Accepted, ParameterType.UrlSegment);
            if (OrderId != null) request.AddParameter("order_id", OrderId, ParameterType.UrlSegment);
            if (State != null) request.AddParameter("state", State, ParameterType.UrlSegment);
            if (Id != null) request.AddParameter("id", Id, ParameterType.UrlSegment);
            if (Page != null) request.AddParameter("page", Page, ParameterType.UrlSegment);
            if (PageSize != null) request.AddParameter("page_size", PageSize, ParameterType.UrlSegment);
            if (SortBy != null) request.AddParameter("sort_by", SortBy, ParameterType.UrlSegment);
            if (SortDir != null) request.AddParameter("sort_dir", SortDir, ParameterType.UrlSegment);


            var response = client.Execute(request);

            return response.Content;
        }
    }
}