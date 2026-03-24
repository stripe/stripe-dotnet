// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionDiscountDetail : StripeEntity<PricingPlanSubscriptionDiscountDetail>
    {
        /// <summary>
        /// The ID of the Discount.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// The time at which the Discount ends, if applicable.
        /// </summary>
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public DateTime? End { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the PromotionCode, if applicable.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// The source of the Discount.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public PricingPlanSubscriptionDiscountDetailSource Source { get; set; }

        /// <summary>
        /// The time at which the Discount starts.
        /// </summary>
        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
