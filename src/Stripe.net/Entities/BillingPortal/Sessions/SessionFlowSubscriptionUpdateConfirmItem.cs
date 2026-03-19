// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionUpdateConfirmItem : StripeEntity<SessionFlowSubscriptionUpdateConfirmItem>, IHasId
    {
        /// <summary>
        /// The ID of the <a
        /// href="https://docs.stripe.com/api/subscriptions/object#subscription_object-items-data-id">subscription
        /// item</a> to be updated.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The price the customer should subscribe to through this flow. The price must also be
        /// included in the configuration's <a
        /// href="https://docs.stripe.com/api/customer_portal/configuration#portal_configuration_object-features-subscription_update-products"><c>features.subscription_update.products</c></a>.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// <a href="https://docs.stripe.com/subscriptions/quantities">Quantity</a> for this item
        /// that the customer should subscribe to through this flow.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
