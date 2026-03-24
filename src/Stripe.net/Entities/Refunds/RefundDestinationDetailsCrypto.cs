// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundDestinationDetailsCrypto : StripeEntity<RefundDestinationDetailsCrypto>
    {
        /// <summary>
        /// The transaction hash of the refund.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
