using System.Text.RegularExpressions;

namespace QuickPayApi
{
    public class RegexFilters
    {
        public static readonly Regex Protocol = new Regex(@"^v[\d]{1,}b?$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Merchant = new Regex(@"^[0-9]{3}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Agreement = new Regex(@"^[0-9]{3}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Ordernumber = new Regex(@"^[0-9]{1,20}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Amount = new Regex(@"^[0-9]{1,9}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Currency = new Regex(@"^[A-Z]{3}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Continueurl = new Regex(@"^https?://",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Cancelurl = new Regex(@"^https?://",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Callbackurl = new Regex(@"^https?://",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex PostTo = new Regex(@"^https?://",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex ApiKey = new Regex(@"^([\w]){64}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Subscription = new Regex(@"^[0-1]{1}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex AutoCapture = new Regex(@"^[0-1]{1}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex PaymentMethods = new Regex(@"^[a-zA-Z,\-]$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public static readonly Regex Descript = new Regex(@"^[\w\s\-\.]{1,20}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant |
            RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
    }
}