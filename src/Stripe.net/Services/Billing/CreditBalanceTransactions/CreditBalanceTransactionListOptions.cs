// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceTransactionListOptions : ListOptions
    {
        /// <summary>
        /// The credit grant for which to fetch credit balance transactions.
        /// </summary>
        [JsonProperty("credit_grant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant")]
#endif
        public string CreditGrant { get; set; }

        /// <summary>
        /// The customer for which to fetch credit balance transactions.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }
    }
}
