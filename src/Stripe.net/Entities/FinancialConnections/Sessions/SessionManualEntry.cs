// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionManualEntry : StripeEntity<SessionManualEntry>
    {
        /// <summary>
        /// Controls how manual entry of bank account details is presented to the user.
        /// One of: <c>automatic</c>, <c>custom</c>, or <c>disabled</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
