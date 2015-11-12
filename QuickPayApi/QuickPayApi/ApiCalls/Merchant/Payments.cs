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

            if (DateYear != null) request.AddParameter("date[year]", DateYear, ParameterType.QueryString);
            if (DateMonth != null) request.AddParameter("date[month]", DateMonth, ParameterType.QueryString);
            if (DateDay != null) request.AddParameter("date[day]", DateDay, ParameterType.QueryString);
            if (DateHour != null) request.AddParameter("date[hour]", DateHour, ParameterType.QueryString);
            if (DateMinute != null) request.AddParameter("date[minute]", DateMinute, ParameterType.QueryString);
            if (Accepted) request.AddParameter("accepted", Accepted, ParameterType.QueryString);
            if (OrderId != null) request.AddParameter("order_id", OrderId, ParameterType.QueryString);
            if (State != null) request.AddParameter("state", State, ParameterType.QueryString);
            if (Id != null) request.AddParameter("id", Id, ParameterType.QueryString);
            if (Page != null) request.AddParameter("page", Page, ParameterType.QueryString);
            if (PageSize != null) request.AddParameter("page_size", PageSize, ParameterType.QueryString);
            if (SortBy != null) request.AddParameter("sort_by", SortBy, ParameterType.QueryString);
            if (SortDir != null) request.AddParameter("sort_dir", SortDir, ParameterType.QueryString);


            var response = client.Execute(request);

            return response.Content;
        }
    }
}