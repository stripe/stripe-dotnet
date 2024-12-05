// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScopeOptions : INestedOptions
    {
        /// <summary>
        /// The price type for which credit grants can apply. We currently only support the
        /// <c>metered</c> price type.
        /// </summary>
        [JsonProperty("price_type")]
        public string PriceType { get; set; }
    }
}
