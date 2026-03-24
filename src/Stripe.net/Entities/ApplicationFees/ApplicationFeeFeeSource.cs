// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApplicationFeeFeeSource : StripeEntity<ApplicationFeeFeeSource>
    {
        /// <summary>
        /// Charge ID that created this application fee.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Payout ID that created this application fee.
        /// </summary>
        [JsonProperty("payout")]
        [STJS.JsonPropertyName("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// Transfer ID that created this application fee.
        /// </summary>
        [JsonProperty("transfer")]
        [STJS.JsonPropertyName("transfer")]
        public string Transfer { get; set; }

        /// <summary>
        /// Type of object that created the application fee.
        /// One of: <c>charge</c>, <c>payout</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
