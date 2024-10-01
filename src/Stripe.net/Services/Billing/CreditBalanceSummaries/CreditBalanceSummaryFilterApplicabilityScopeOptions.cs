// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceSummaryFilterApplicabilityScopeOptions : INestedOptions
    {
        /// <summary>
        /// The price type to which credit grants can apply to. We currently only support
        /// <c>metered</c> price type.
        /// </summary>
        [JsonProperty("price_type")]
        public string PriceType { get; set; }
    }
}
