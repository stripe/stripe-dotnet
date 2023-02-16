// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class SessionManualEntryOptions : INestedOptions
    {
        /// <summary>
        /// Whether manual entry will be handled by Stripe during the Session.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
