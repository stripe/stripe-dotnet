// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class EventQuantity : StripeEntity<EventQuantity>
    {
        /// <summary>
        /// When granting or revoking an entitlement to a type=quantity feature, you must specify
        /// the number of units you're granting/revoking. When the entitlement event type=grant,
        /// this number increments the total quantity available to the customer, and when
        /// type=revoke it decrements the total quantity available to the customer.
        /// </summary>
        [JsonProperty("units")]
        public long Units { get; set; }
    }
}
