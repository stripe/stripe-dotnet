// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the <c>completed_sessions</c> restriction type.
        /// </summary>
        [JsonProperty("completed_sessions")]
        public PaymentLinkRestrictionsCompletedSessionsOptions CompletedSessions { get; set; }
    }
}
