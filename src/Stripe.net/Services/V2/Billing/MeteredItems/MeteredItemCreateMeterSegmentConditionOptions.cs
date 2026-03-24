// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeteredItemCreateMeterSegmentConditionOptions : INestedOptions
    {
        /// <summary>
        /// A Meter dimension.
        /// </summary>
        [JsonProperty("dimension")]
        [STJS.JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// To count usage towards this metered item, the dimension must have this value.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
