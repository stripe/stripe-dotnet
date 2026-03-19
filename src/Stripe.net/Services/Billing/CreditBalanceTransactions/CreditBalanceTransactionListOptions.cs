// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditBalanceTransactionListOptions : ListOptions
    {
        /// <summary>
        /// The credit grant for which to fetch credit balance transactions.
        /// </summary>
        [JsonProperty("credit_grant")]
        [STJS.JsonPropertyName("credit_grant")]
        public string CreditGrant { get; set; }

        /// <summary>
        /// The customer whose credit balance transactions you're retrieving.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The account representing the customer whose credit balance transactions you're
        /// retrieving.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }
    }
}
