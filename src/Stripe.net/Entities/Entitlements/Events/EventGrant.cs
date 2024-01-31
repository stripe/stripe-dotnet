// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventGrant : StripeEntity<EventGrant>
    {
        /// <summary>
        /// When manually creating a grant entitlement event, you can make it a temporary grant by
        /// setting it to expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Who/what created this grant entitlement event.
        /// One of: <c>subscription_item</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("granted_by")]
        public string GrantedBy { get; set; }

        /// <summary>
        /// If this entitlement event was created by a subscription_item, this will contains
        /// information about the subscription_item.
        /// </summary>
        [JsonProperty("subscription_item")]
        public EventGrantSubscriptionItem SubscriptionItem { get; set; }
    }
}
