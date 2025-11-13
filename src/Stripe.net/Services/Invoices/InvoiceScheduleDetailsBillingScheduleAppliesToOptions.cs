// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsBillingScheduleAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// Controls which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
