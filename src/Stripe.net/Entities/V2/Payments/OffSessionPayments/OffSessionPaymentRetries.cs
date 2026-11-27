// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentRetries : StripeEntity<OffSessionPaymentRetries>
    {
        /// <summary>
        /// Number of authorization attempts so far.
        /// </summary>
        [JsonProperty("attempts")]
        [STJS.JsonPropertyName("attempts")]
        public long Attempts { get; set; }

        /// <summary>
        /// Whether retries are enabled for this OffSessionPayment.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
