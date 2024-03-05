// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitCreateOptions : BaseOptions
    {
        /// <summary>
        /// Amount (in cents) to be transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount to pull funds from.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Initiating payment method details for the object.
        /// </summary>
        [JsonProperty("initiating_payment_method_details")]
        public ReceivedDebitInitiatingPaymentMethodDetailsOptions InitiatingPaymentMethodDetails { get; set; }

        /// <summary>
        /// Specifies the network rails to be used. If not set, will default to the PaymentMethod's
        /// preferred network. See the <a
        /// href="https://stripe.com/docs/treasury/money-movement/timelines">docs</a> to learn more
        /// about money movement timelines for each network type.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }
    }
}
