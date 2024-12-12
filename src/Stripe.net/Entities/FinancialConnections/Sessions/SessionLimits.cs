// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionLimits : StripeEntity<SessionLimits>
    {
        /// <summary>
        /// The number of accounts that can be linked in this Session.
        /// </summary>
        [JsonProperty("accounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accounts")]
#endif
        public long Accounts { get; set; }
    }
}
