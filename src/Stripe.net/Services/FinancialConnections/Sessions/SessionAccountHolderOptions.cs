// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class SessionAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose accounts will be retrieved. Should only be present if
        /// <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Stripe customer whose accounts will be retrieved. Should only be present
        /// if <c>type</c> is <c>customer</c>.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Type of account holder to collect accounts for.
        /// One of: <c>account</c>, or <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
