// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceSummaryGetOptions : BaseOptions
    {
        /// <summary>
        /// The customer for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The filter criteria for the credit balance summary.
        /// </summary>
        [JsonProperty("filter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filter")]
#endif
        public CreditBalanceSummaryFilterOptions Filter { get; set; }
    }
}
