// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCryptoTransactionVerificationOptions : StripeEntity<PaymentIntentPaymentMethodOptionsCryptoTransactionVerificationOptions>
    {
        /// <summary>
        /// The network on which the transaction was submitted.
        /// One of: <c>base</c>, <c>ethereum</c>, <c>polygon</c>, <c>solana</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The hash of the onchain transaction to verify.
        /// </summary>
        [JsonProperty("transaction_hash")]
        [STJS.JsonPropertyName("transaction_hash")]
        public string TransactionHash { get; set; }
    }
}
