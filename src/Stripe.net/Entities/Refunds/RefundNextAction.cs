// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundNextAction : StripeEntity<RefundNextAction>
    {
        [JsonProperty("display_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_details")]
#endif
        public RefundNextActionDisplayDetails DisplayDetails { get; set; }

        /// <summary>
        /// Type of the next action to perform.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
