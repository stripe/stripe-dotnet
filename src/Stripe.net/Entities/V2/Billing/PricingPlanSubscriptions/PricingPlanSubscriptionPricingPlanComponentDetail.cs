// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetail : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetail>
    {
        /// <summary>
        /// License fee details, present when type is license_fee_details.
        /// </summary>
        [JsonProperty("license_fee_details")]
        [STJS.JsonPropertyName("license_fee_details")]
        public PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetails LicenseFeeDetails { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Component.
        /// </summary>
        [JsonProperty("pricing_plan_component")]
        [STJS.JsonPropertyName("pricing_plan_component")]
        public string PricingPlanComponent { get; set; }

        /// <summary>
        /// Rate card details, present when type is rate_card_details.
        /// </summary>
        [JsonProperty("rate_card_details")]
        [STJS.JsonPropertyName("rate_card_details")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetails RateCardDetails { get; set; }

        /// <summary>
        /// Recurring credit grant details, present when type is recurring_credit_grant_details.
        /// </summary>
        [JsonProperty("recurring_credit_grant_details")]
        [STJS.JsonPropertyName("recurring_credit_grant_details")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetails RecurringCreditGrantDetails { get; set; }

        /// <summary>
        /// The type of component details included.
        /// One of: <c>license_fee_details</c>, <c>rate_card_details</c>, or
        /// <c>recurring_credit_grant_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
