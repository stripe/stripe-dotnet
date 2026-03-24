// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PricingPlanSubscriptionListPayerOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Customer object. If provided, only Pricing Plan Subscriptions that are
        /// subscribed on the cadences with the specified payer will be returned.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// A string identifying the type of the payer. Currently the only supported value is
        /// <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
