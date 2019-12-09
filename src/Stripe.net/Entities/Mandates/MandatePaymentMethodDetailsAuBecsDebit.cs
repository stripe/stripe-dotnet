namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsAuBecsDebit : StripeEntity<MandatePaymentMethodDetailsAuBecsDebit>
    {
        /// <summary>
        /// The URL of the mandate. This URL generally contains sensitive information about the
        /// customer and should be shared with them exclusively.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
