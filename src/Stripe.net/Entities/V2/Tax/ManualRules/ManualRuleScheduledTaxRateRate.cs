// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ManualRuleScheduledTaxRateRate : StripeEntity<ManualRuleScheduledTaxRateRate>
    {
        /// <summary>
        /// Country of the tax rate.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Description of the tax rate.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Display name of the tax rate as it will be shown on the invoice.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Jurisdiction of the tax rate should apply as it will be shown on the invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }

        /// <summary>
        /// Percentage of the tax rate. Must be positive and maximum of 4 decimal points.
        /// </summary>
        [JsonProperty("percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percentage")]
#endif
        public string Percentage { get; set; }

        /// <summary>
        /// State of the tax rate.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }
    }
}
