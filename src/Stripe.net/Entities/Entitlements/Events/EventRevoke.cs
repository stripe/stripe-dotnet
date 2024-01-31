// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventRevoke : StripeEntity<EventRevoke>
    {
        /// <summary>
        /// A revoke entitlement event will always expire at the same time as the grant it is
        /// revoking.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Who/what created this revoke entitlement event.
        /// One of: <c>subscription_item</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("revoked_by")]
        public string RevokedBy { get; set; }

        /// <summary>
        /// If this entitlement event was created by a subscription_item, this will contains
        /// information about the subscription_item.
        /// </summary>
        [JsonProperty("subscription_item")]
        public EventRevokeSubscriptionItem SubscriptionItem { get; set; }
    }
}
