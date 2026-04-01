// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a Stripe Access Grant is approved.
    /// </summary>
    public class V2IamStripeAccessGrantApprovedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.stripe_access_grant.approved event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamStripeAccessGrantApprovedEventData Data { get; set; }
    }
}
