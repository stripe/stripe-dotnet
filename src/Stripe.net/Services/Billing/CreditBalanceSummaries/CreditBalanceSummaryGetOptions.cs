// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceSummaryGetOptions : BaseOptions
    {
        /// <summary>
        /// The customer for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The filter criteria for the credit balance summary.
        /// </summary>
        [JsonProperty("filter")]
        public CreditBalanceSummaryFilterOptions Filter { get; set; }
    }
}
