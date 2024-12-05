// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkRestrictions : StripeEntity<PaymentLinkRestrictions>
    {
        [JsonProperty("completed_sessions")]
        public PaymentLinkRestrictionsCompletedSessions CompletedSessions { get; set; }
    }
}
