using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickPayApi
{
    public class PaymentRequestParameters
    {
        private string _agreement = Constants.Agreement;
        private string _amount;
        private string _apiKey = Constants.Keys.PaymentWindow;
        private string _autoCapture = Constants.AutoCapture;
        private string _callbackurl = Constants.Callbackurl;
        private string _cancelurl = Constants.Cancelurl;
        private string _continueurl = Constants.Continueurl;
        private string _currency = Constants.Currency;
        private string _merchant = Constants.Merchant;
        private string _paymentMethods = Constants.PaymentMethods;
        private string _postTo = Constants.PostTo;
        private string _protocol = Constants.Protocol;
        private string _subscription = Constants.Subscription;

        public string Checksum { get; set; }
        public string FormString { get; set; }
        public string Description { get; set; }

        public string Merchant
        {
            get { return _merchant; }
            set
            {
                if (!RegexFilters.Merchant.IsMatch(value)) throw new ArgumentException();
                _merchant = value;
            }
        }

        public string Protocol
        {
            get { return _protocol; }
            set
            {
                if (!RegexFilters.Protocol.IsMatch(value)) throw new ArgumentException();
                _protocol = value;
            }
        }

        public string Ordernumber { get; set; }

        public string Amount
        {
            get { return _amount; }
            set
            {
                if (!RegexFilters.Amount.IsMatch(value)) throw new ArgumentException();
                _amount = value;
            }
        }

        public string Currency
        {
            get { return _currency; }
            set
            {
                if (!RegexFilters.Currency.IsMatch(value)) throw new ArgumentException();
                _currency = value;
            }
        }

        public string Agreement
        {
            get { return _agreement; }
            set
            {
                if (!RegexFilters.Agreement.IsMatch(value)) throw new ArgumentException();
                _agreement = value;
            }
        }

        public string ContinueUrl
        {
            get { return _continueurl; }
            set
            {
                if (!RegexFilters.Continueurl.IsMatch(value)) throw new ArgumentException();
                _continueurl = value;
            }
        }

        public string CancelUrl
        {
            get { return _cancelurl; }
            set
            {
                if (!RegexFilters.Cancelurl.IsMatch(value)) throw new ArgumentException();
                _cancelurl = value;
            }
        }

        public string Callbackurl
        {
            get { return _callbackurl; }
            set
            {
                if (!RegexFilters.Callbackurl.IsMatch(value)) throw new ArgumentException();
                _callbackurl = value;
            }
        }

        public string ApiKey
        {
            get { return _apiKey; }
            set
            {
                if (!RegexFilters.ApiKey.IsMatch(value)) throw new ArgumentException();
                _apiKey = value;
            }
        }

        public string PostTo
        {
            get { return _postTo; }
            set
            {
                if (!RegexFilters.PostTo.IsMatch(value)) throw new ArgumentException();
                _postTo = value;
            }
        }

        public string Subscription
        {
            get { return _subscription; }
            set
            {
                if (!RegexFilters.Subscription.IsMatch(value)) throw new ArgumentException();
                _subscription = value;
            }
        }

        public string AutoCapture
        {
            get { return _subscription; }
            set
            {
                if (!RegexFilters.AutoCapture.IsMatch(value)) throw new ArgumentException();
                _autoCapture = value;
            }
        }

        public string PaymentMethods
        {
            get { return _paymentMethods; }
            set
            {
                if (!RegexFilters.PaymentMethods.IsMatch(value)) throw new ArgumentException();
                _paymentMethods = value;
            }
        }

        /// <summary>
        ///     Calculates the checksum.
        /// </summary>
        /// <returns>Sh252 encrypted string</returns>
        public string CalculateChecksum()
        {
            var valueArrary = new Dictionary<string, string>
            {
                {"version", Protocol},
                {"merchant_id", Merchant},
                {"agreement_id", Agreement},
                {"order_id", Ordernumber},
                {"amount", Amount},
                {"currency", Currency},
                {"continueurl", ContinueUrl},
                {"cancelurl", CancelUrl},
                {"callbackurl", Callbackurl},
                {"subscription", Subscription},
                {"description", Description},
                {"autocapture", AutoCapture},
                {"payment_methods", PaymentMethods}
            };

            Checksum = string.Join(" ", valueArrary.OrderBy(x => x.Key).Select(x => x.Value));

            return Cryptography.CreateToken(Checksum, ApiKey);
        }

        /// <summary>
        ///     Generates the html form.
        /// </summary>
        /// <returns></returns>
        public string GenerateForm()
        {
            var sb = new StringBuilder();
            var parametersArrary = new Dictionary<string, string>
            {
                {"version", Protocol},
                {"merchant_id", Merchant},
                {"agreement_id", Agreement},
                {"order_id", Ordernumber},
                {"amount", Amount},
                {"currency", Currency},
                {"continueurl", ContinueUrl},
                {"cancelurl", CancelUrl},
                {"callbackurl", Callbackurl},
                {"checksum", Checksum},
                {"autocapture", AutoCapture},
                {"subscription", Subscription},
                {"payment_methods", PaymentMethods},
                {"description", Description}
            };

            sb.Append($"<form action=\"{PostTo}\" method=\"POST\">");
            foreach (var d in parametersArrary)
            {
                sb.Append($"<input type=\"hidden\" name=\"{d.Key}\" value=\"{d.Value}\" />");
            }
            sb.Append("<input type=\"submit\" id=\"pay\" value=\"Continue to payment...\">");

            return sb.ToString();
        }
    }
}