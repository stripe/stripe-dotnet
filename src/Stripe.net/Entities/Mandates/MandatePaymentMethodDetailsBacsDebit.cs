namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsBacsDebit : StripeEntity<MandatePaymentMethodDetailsBacsDebit>
    {
        /// <summary>
        /// The status of the mandate on the Bacs network. Can be one of <c>pending</c>,
        /// <c>revoked</c>, <c>refused</c>, or <c>accepted</c>.
        /// One of: <c>accepted</c>, <c>pending</c>, <c>refused</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        /// <summary>
        /// The unique reference identifying the mandate on the Bacs network.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL that will contain the mandate that the customer has signed.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
