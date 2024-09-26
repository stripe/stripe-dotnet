// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceTransactionListOptions : ListOptions
    {
        /// <summary>
        /// The credit grant for which to fetch credit balance transactions.
        /// </summary>
        [JsonProperty("credit_grant")]
        public string CreditGrant { get; set; }

        /// <summary>
        /// The customer for which to fetch credit balance transactions.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
