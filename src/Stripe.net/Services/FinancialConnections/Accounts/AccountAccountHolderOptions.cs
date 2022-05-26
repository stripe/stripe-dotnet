// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class AccountAccountHolderOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose accounts will be retrieved.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the Stripe customer whose accounts will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
