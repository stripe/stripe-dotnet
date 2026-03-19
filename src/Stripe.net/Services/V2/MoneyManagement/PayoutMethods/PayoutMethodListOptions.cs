// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutMethodListOptions : V2.ListOptions
    {
        /// <summary>
        /// Usage status filter.
        /// </summary>
        [JsonProperty("usage_status")]
        [STJS.JsonPropertyName("usage_status")]
        public PayoutMethodListUsageStatusOptions UsageStatus { get; set; }
    }
}
