// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Stripe Access Grant is denied (was pending, then denied by the customer).
    /// </summary>
    public class V2IamStripeAccessGrantDeniedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.stripe_access_grant.denied event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamStripeAccessGrantDeniedEventData Data { get; set; }
    }
}
