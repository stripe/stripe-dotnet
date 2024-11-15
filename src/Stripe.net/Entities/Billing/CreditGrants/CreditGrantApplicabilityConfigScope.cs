// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantApplicabilityConfigScope : StripeEntity<CreditGrantApplicabilityConfigScope>
    {
        /// <summary>
        /// The price type to which credit grants can apply to. We currently only support
        /// <c>metered</c> price type. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// </summary>
        [JsonProperty("price_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_type")]
#endif

        public string PriceType { get; set; }
    }
}
