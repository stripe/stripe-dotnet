namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsBacsDebit : StripeEntity<MandatePaymentMethodDetailsBacsDebit>
    {
        /// <summary>
        /// The status of the mandate on the network and whether it's been accepted or revoked.
        /// </summary>
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        /// <summary>
        /// The reference associated with the mandate.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL to view the mandate.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
