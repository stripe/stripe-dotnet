// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodListOptions : V2.ListOptions
    {
        /// <summary>
        /// Usage status filter.
        /// </summary>
        [JsonProperty("usage_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_status")]
#endif
        public PayoutMethodListUsageStatusOptions UsageStatus { get; set; }
    }
}
