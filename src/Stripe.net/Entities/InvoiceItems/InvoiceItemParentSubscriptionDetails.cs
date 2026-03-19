// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParentSubscriptionDetails : StripeEntity<InvoiceItemParentSubscriptionDetails>
    {
        /// <summary>
        /// The subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription_item")]
        [STJS.JsonPropertyName("subscription_item")]
        public string SubscriptionItem { get; set; }
    }
}
