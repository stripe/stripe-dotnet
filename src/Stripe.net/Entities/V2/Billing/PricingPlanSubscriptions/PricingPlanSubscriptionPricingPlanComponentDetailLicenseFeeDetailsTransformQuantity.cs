// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetailsTransformQuantity : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetailsTransformQuantity>
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonProperty("divide_by")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("divide_by")]
        public long DivideBy { get; set; }

        /// <summary>
        /// After division, round the result up or down.
        /// One of: <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("round")]
        [STJS.JsonPropertyName("round")]
        public string Round { get; set; }
    }
}
