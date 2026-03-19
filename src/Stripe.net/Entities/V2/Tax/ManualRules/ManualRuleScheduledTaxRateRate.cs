// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ManualRuleScheduledTaxRateRate : StripeEntity<ManualRuleScheduledTaxRateRate>
    {
        /// <summary>
        /// Country of the tax rate.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Description of the tax rate.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Display name of the tax rate as it will be shown on the invoice.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Jurisdiction of the tax rate should apply as it will be shown on the invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
        [STJS.JsonPropertyName("jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// Percentage of the tax rate. Must be positive and maximum of 4 decimal points.
        /// </summary>
        [JsonProperty("percentage")]
        [STJS.JsonPropertyName("percentage")]
        public string Percentage { get; set; }

        /// <summary>
        /// State of the tax rate.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
