// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditionOptions : INestedOptions
    {
        /// <summary>
        /// The type of condition.
        /// One of: <c>decreasing_item_amount</c>, or <c>shortening_interval</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
