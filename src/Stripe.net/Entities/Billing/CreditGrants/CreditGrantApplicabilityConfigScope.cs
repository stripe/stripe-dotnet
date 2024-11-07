// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfigScope : StripeEntity<CreditGrantApplicabilityConfigScope>
    {
        /// <summary>
        /// The price type for which credit grants can apply. We currently only support the
        /// <c>metered</c> price type. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// </summary>
        [JsonProperty("price_type")]
        public string PriceType { get; set; }
    }
}
