// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetails : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetails>
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A customer-facing name for the rate card.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of the Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }

        /// <summary>
        /// The service cycle configuration.
        /// </summary>
        [JsonProperty("service_cycle")]
        [STJS.JsonPropertyName("service_cycle")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetailsServiceCycle ServiceCycle { get; set; }

        /// <summary>
        /// Whether the rates are inclusive or exclusive of tax.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
