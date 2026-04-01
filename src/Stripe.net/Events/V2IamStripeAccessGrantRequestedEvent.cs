// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Stripe Access Grant is requested.
    /// </summary>
    public class V2IamStripeAccessGrantRequestedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.stripe_access_grant.requested event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamStripeAccessGrantRequestedEventData Data { get; set; }
    }
}
