// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the <c>completed_sessions</c> restriction type.
        /// </summary>
        [JsonProperty("completed_sessions")]
        [STJS.JsonPropertyName("completed_sessions")]
        public PaymentLinkRestrictionsCompletedSessionsOptions CompletedSessions { get; set; }
    }
}
