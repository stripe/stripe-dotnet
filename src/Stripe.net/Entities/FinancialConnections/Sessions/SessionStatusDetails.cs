// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class SessionStatusDetails : StripeEntity<SessionStatusDetails>
    {
        [JsonProperty("cancelled")]
        public SessionStatusDetailsCancelled Cancelled { get; set; }
    }
}
