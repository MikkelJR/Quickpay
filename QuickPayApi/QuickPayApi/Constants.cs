namespace QuickPayApi
{
    public class Constants
    {
        /// <summary>
        ///     Payment parameters
        /// </summary>
        public const string PostTo = "https://payment.quickpay.net";

        public const string Protocol = "v10";
        public const string Merchant = "358";
        public const string Agreement = "875";
        public const string Currency = "DKK";
        public const string Continueurl = "https://example.com/QuickPay/Continue";
        public const string Cancelurl = "https://example.com/QuickPay/Cancel";
        public const string Callbackurl = "https://example.com/QuickPay/Callback";
        public const string Subscription = "1";
        public const string AutoCapture = "1";
        public const string PaymentMethods = "dankort, mastercard, mastercard-debet, visa, visa-electron";

        /// <summary>
        ///     Api constants
        /// </summary>
        public const string ApiBaseUrl = "https://api.quickpay.net";

        public const string ApiVersionHeader = "v10";
        public const int DefaultPageSize = 20;
        public const int DefaultPage = 1;

        public class Keys
        {
            public const string Api = "API-KEY";
            public const string PaymentWindow = "PAYMENT-WINDOW-API-KEY";
        }
    }
}