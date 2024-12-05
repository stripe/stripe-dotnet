// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceTransactionCredit : StripeEntity<CreditBalanceTransactionCredit>
    {
        [JsonProperty("amount")]
        public CreditBalanceTransactionCreditAmount Amount { get; set; }

        /// <summary>
        /// The type of credit transaction.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
