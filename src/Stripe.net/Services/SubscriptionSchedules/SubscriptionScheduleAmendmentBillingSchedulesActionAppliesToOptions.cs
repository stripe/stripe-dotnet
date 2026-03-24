// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleAmendmentBillingSchedulesActionAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Controls which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
