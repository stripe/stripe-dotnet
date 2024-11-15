// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlowSubscriptionUpdateConfirm : StripeEntity<SessionFlowSubscriptionUpdateConfirm>
    {
        /// <summary>
        /// The coupon or promotion code to apply to this subscription update. Currently, only up to
        /// one may be specified.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif

        public List<SessionFlowSubscriptionUpdateConfirmDiscount> Discounts { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/subscription_items">subscription item</a> to be
        /// updated through this flow. Currently, only up to one may be specified and subscriptions
        /// with multiple items are not updatable.
        /// </summary>
        [JsonProperty("items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("items")]
#endif

        public List<SessionFlowSubscriptionUpdateConfirmItem> Items { get; set; }

        /// <summary>
        /// The ID of the subscription to be updated.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif

        public string Subscription { get; set; }
    }
}
