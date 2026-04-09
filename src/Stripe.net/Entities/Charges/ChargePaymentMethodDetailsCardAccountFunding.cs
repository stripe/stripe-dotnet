// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardAccountFunding : StripeEntity<ChargePaymentMethodDetailsCardAccountFunding>
    {
        /// <summary>
        /// The transaction type of the card transaction. One of <c>account_funding</c> or
        /// <c>purchase</c>.
        /// One of: <c>account_funding</c>, or <c>purchase</c>.
        /// </summary>
        [JsonProperty("processed_transaction_type")]
        [STJS.JsonPropertyName("processed_transaction_type")]
        public string ProcessedTransactionType { get; set; }
    }
}
