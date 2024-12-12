// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlowDataSubscriptionUpdateConfirmItemOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the <a
        /// href="https://stripe.com/docs/api/subscriptions/object#subscription_object-items-data-id">subscription
        /// item</a> to be updated.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The price the customer should subscribe to through this flow. The price must also be
        /// included in the configuration's <a
        /// href="https://stripe.com/docs/api/customer_portal/configuration#portal_configuration_object-features-subscription_update-products"><c>features.subscription_update.products</c></a>.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/subscriptions/quantities">Quantity</a> for this item
        /// that the customer should subscribe to through this flow.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }
    }
}
