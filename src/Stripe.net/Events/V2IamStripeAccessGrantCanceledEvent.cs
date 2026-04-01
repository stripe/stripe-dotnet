// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Stripe Access Grant is canceled by the requesting Stripe.
    /// </summary>
    public class V2IamStripeAccessGrantCanceledEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.stripe_access_grant.canceled event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamStripeAccessGrantCanceledEventData Data { get; set; }
    }
}
