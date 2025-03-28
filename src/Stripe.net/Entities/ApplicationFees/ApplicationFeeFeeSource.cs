// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApplicationFeeFeeSource : StripeEntity<ApplicationFeeFeeSource>
    {
        /// <summary>
        /// Charge ID that created this application fee.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// Payout ID that created this application fee.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif
        public string Payout { get; set; }

        /// <summary>
        /// Type of object that created the application fee.
        /// One of: <c>charge</c>, or <c>payout</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
