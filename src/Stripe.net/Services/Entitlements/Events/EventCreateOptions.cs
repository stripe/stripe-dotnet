// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class EventCreateOptions : BaseOptions
    {
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
        public EventGrantOptions Grant { get; set; }

        /// <summary>
        /// Contains information about entitlement events relating to features with type=quantity.
        /// Required when the feature has type=quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public EventQuantityOptions Quantity { get; set; }

        /// <summary>
        /// Whether the event is a grant or revocation of the feature.
        /// One of: <c>grant</c>, or <c>revoke</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
