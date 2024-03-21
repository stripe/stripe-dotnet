// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    /// <summary>
    /// A summary of a customer's active entitlements.
    /// </summary>
    public class ActiveEntitlementSummary : StripeEntity<ActiveEntitlementSummary>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The customer that is entitled to this feature.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The list of entitlements this customer has.
        /// </summary>
        [JsonProperty("entitlements")]
        public StripeList<ActiveEntitlement> Entitlements { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
