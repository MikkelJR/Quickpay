namespace QuickPayApi
{
    public class Enums
    {
        public enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public enum SubscriptionSortBy
        {
            Id,
            OrderId
        }

        public enum SubscriptionSortDir
        {
            Asc,
            Desc
        }

        public enum SubscriptionStates
        {
            Pending,
            New,
            Rejected,
            Processed
        }
    }
}