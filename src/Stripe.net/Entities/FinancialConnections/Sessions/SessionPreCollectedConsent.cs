// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPreCollectedConsent : StripeEntity<SessionPreCollectedConsent>
    {
        /// <summary>
        /// The outcome of evaluating the pre-collected consent submitted for this Session.
        /// One of: <c>consent_accepted</c>, or <c>consent_required</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }
    }
}
