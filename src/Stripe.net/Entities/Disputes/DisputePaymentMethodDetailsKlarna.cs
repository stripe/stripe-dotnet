// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetailsKlarna : StripeEntity<DisputePaymentMethodDetailsKlarna>
    {
        /// <summary>
        /// The reason for the dispute as defined by Klarna.
        /// </summary>
        [JsonProperty("reason_code")]
        public string ReasonCode { get; set; }
    }
}
