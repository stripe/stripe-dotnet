// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionStatusDetailsCancelled : StripeEntity<SessionStatusDetailsCancelled>
    {
        /// <summary>
        /// The reason for the Session being cancelled.
        /// One of: <c>custom_manual_entry</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
