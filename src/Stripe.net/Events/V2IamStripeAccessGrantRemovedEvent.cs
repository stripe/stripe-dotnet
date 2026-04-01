// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Stripe Access Grant is removed (was approved, and then removed by the
    /// customer).
    /// </summary>
    public class V2IamStripeAccessGrantRemovedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.stripe_access_grant.removed event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamStripeAccessGrantRemovedEventData Data { get; set; }
    }
}
