// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class EventRevokeSubscriptionItem : StripeEntity<EventRevokeSubscriptionItem>
    {
        /// <summary>
        /// The subscription line item quantity.
        /// </summary>
        [JsonProperty("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// The price for the product that contains the feature for this entitlement event.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The product that contains the feature for this entitlement event.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The subscription that created this entitlement event.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that created this entitlement event.
        /// </summary>
        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }
    }
}
