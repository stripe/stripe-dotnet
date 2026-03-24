// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionStatusDetailsCancelled : StripeEntity<SessionStatusDetailsCancelled>
    {
        /// <summary>
        /// The reason for the Session being cancelled.
        /// One of: <c>custom_manual_entry</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
