// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertUsageThresholdFilterOptions : INestedOptions
    {
        /// <summary>
        /// Limit the scope to this usage alert only to this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// What type of filter is being applied to this usage alert.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
