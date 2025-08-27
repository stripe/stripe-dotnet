// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeteredItemMeterSegmentCondition : StripeEntity<MeteredItemMeterSegmentCondition>
    {
        /// <summary>
        /// A Meter dimension.
        /// </summary>
        [JsonProperty("dimension")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dimension")]
#endif
        public string Dimension { get; set; }

        /// <summary>
        /// To count usage towards this metered item, the dimension must have this value.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
