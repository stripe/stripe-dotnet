// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class SessionLimitsOptions : INestedOptions
    {
        /// <summary>
        /// The number of accounts that can be linked in this Session.
        /// </summary>
        [JsonProperty("accounts")]
        public long? Accounts { get; set; }
    }
}
