// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsLicenseFeeComponent : StripeEntity<SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurationsLicenseFeeComponent>
    {
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
