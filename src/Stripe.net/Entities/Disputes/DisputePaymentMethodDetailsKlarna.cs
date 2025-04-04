// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputePaymentMethodDetailsKlarna : StripeEntity<DisputePaymentMethodDetailsKlarna>
    {
        /// <summary>
        /// The reason for the dispute as defined by Klarna.
        /// </summary>
        [JsonProperty("reason_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason_code")]
#endif
        public string ReasonCode { get; set; }
    }
}
