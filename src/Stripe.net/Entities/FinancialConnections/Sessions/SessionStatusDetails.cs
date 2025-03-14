// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionStatusDetails : StripeEntity<SessionStatusDetails>
    {
        [JsonProperty("cancelled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancelled")]
#endif
        public SessionStatusDetailsCancelled Cancelled { get; set; }
    }
}
