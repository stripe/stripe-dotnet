// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionFlowDataSubscriptionUpdateConfirmOptions : INestedOptions
    {
        /// <summary>
        /// The coupon or promotion code to apply to this subscription update. Currently, only up to
        /// one may be specified.
        /// </summary>
        [JsonProperty("discounts")]
        public List<SessionFlowDataSubscriptionUpdateConfirmDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/subscription_items">subscription item</a> to be
        /// updated through this flow. Currently, only up to one may be specified and subscriptions
        /// with multiple items are not updatable.
        /// </summary>
        [JsonProperty("items")]
        public List<SessionFlowDataSubscriptionUpdateConfirmItemOptions> Items { get; set; }

        /// <summary>
        /// The ID of the subscription to be updated.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
