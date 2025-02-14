// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScope : StripeEntity<CreditGrantApplicabilityConfigScope>
    {
        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// </summary>
        [JsonProperty("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// The prices that credit grants can apply to. We currently only support <c>metered</c>
        /// prices. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// </summary>
        [JsonProperty("prices")]
        public List<CreditGrantApplicabilityConfigScopePrice> Prices { get; set; }
    }
}
