// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceTransactionCreditAmount : StripeEntity<CreditBalanceTransactionCreditAmount>
    {
        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
        public CreditBalanceTransactionCreditAmountMonetary Monetary { get; set; }

        /// <summary>
        /// The type of this amount. We currently only support <c>monetary</c> billing credits.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
