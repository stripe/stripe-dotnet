// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsOptions : INestedOptions
    {
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("license_fee_component")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_component")]
#endif
        public SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsLicenseFeeComponentOptions LicenseFeeComponent { get; set; }
    }
}
