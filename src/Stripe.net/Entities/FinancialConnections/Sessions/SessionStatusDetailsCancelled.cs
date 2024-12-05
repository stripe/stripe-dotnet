// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class SessionStatusDetailsCancelled : StripeEntity<SessionStatusDetailsCancelled>
    {
        /// <summary>
        /// The reason for the Session being cancelled.
        /// One of: <c>custom_manual_entry</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
