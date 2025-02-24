// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScopeOptions : INestedOptions
    {
        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type.
        /// </summary>
        [JsonProperty("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// A list of prices that the credit grant can apply to. We currently only support the
        /// <c>metered</c> prices.
        /// </summary>
        [JsonProperty("prices")]
        public List<CreditGrantApplicabilityConfigScopePriceOptions> Prices { get; set; }
    }
}
