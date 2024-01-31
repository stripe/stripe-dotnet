// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    /// <summary>
    /// An entitlement event either grants or revokes an entitlement to a feature for a
    /// customer.
    /// </summary>
    public class Event : StripeEntity<Event>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The customer that is being granted or revoked entitlement to/from a feature.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The feature that the customer is being granted/revoked entitlement to/from.
        /// </summary>
        [JsonProperty("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// Contains information about type=grant entitlement event.
        /// </summary>
        [JsonProperty("grant")]
        public EventGrant Grant { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Contains information about entitlement events relating to features with type=quantity.
        /// Required when the feature has type=quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public EventQuantity Quantity { get; set; }

        /// <summary>
        /// Contains information about type=revoke entitlement event.
        /// </summary>
        [JsonProperty("revoke")]
        public EventRevoke Revoke { get; set; }

        /// <summary>
        /// Whether the event is a grant or revocation of the feature.
        /// One of: <c>grant</c>, or <c>revoke</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
