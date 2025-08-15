// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AutomaticRuleCreateOptions : BaseOptions
    {
        /// <summary>
        /// The BillableItem ID to set automatic Tax configuration for.
        /// </summary>
        [JsonProperty("billable_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billable_item")]
#endif
        public string BillableItem { get; set; }

        /// <summary>
        /// The TaxCode object to be used for automatic tax calculations.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
