// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurations : StripeEntity<SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurations>
    {
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("license_fee_component")]
        [STJS.JsonPropertyName("license_fee_component")]
        public SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsLicenseFeeComponent LicenseFeeComponent { get; set; }
    }
}
