// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkRestrictions : StripeEntity<PaymentLinkRestrictions>
    {
        [JsonProperty("completed_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("completed_sessions")]
#endif

        public PaymentLinkRestrictionsCompletedSessions CompletedSessions { get; set; }
    }
}
