// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionStatusDetails : StripeEntity<SessionStatusDetails>
    {
        [JsonProperty("cancelled")]
        [STJS.JsonPropertyName("cancelled")]
        public SessionStatusDetailsCancelled Cancelled { get; set; }
    }
}
