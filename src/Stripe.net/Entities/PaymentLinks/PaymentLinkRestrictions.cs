// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkRestrictions : StripeEntity<PaymentLinkRestrictions>
    {
        [JsonProperty("completed_sessions")]
        [STJS.JsonPropertyName("completed_sessions")]
        public PaymentLinkRestrictionsCompletedSessions CompletedSessions { get; set; }
    }
}
