// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionUpdateConfirm : StripeEntity<SessionFlowSubscriptionUpdateConfirm>
    {
        /// <summary>
        /// The coupon or promotion code to apply to this subscription update.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SessionFlowSubscriptionUpdateConfirmDiscount> Discounts { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/subscription_items">subscription item</a> to be
        /// updated through this flow. Currently, only up to one may be specified and subscriptions
        /// with multiple items are not updatable.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<SessionFlowSubscriptionUpdateConfirmItem> Items { get; set; }

        /// <summary>
        /// The ID of the subscription to be updated.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
