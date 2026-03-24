// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionLimitsOptions : INestedOptions
    {
        /// <summary>
        /// The number of accounts that can be linked in this Session.
        /// </summary>
        [JsonProperty("accounts")]
        [STJS.JsonPropertyName("accounts")]
        public long? Accounts { get; set; }
    }
}
