// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationCryptoTransaction : StripeEntity<AuthorizationCryptoTransaction>
    {
        /// <summary>
        /// The confirmed crypto transaction details when <c>type</c> is
        /// <c>crypto_transaction_confirmed</c>; otherwise null.
        /// </summary>
        [JsonProperty("crypto_transaction_confirmed")]
        [STJS.JsonPropertyName("crypto_transaction_confirmed")]
        public AuthorizationCryptoTransactionCryptoTransactionConfirmed CryptoTransactionConfirmed { get; set; }

        /// <summary>
        /// The failed crypto transaction details when <c>type</c> is
        /// <c>crypto_transaction_failed</c>; otherwise null.
        /// </summary>
        [JsonProperty("crypto_transaction_failed")]
        [STJS.JsonPropertyName("crypto_transaction_failed")]
        public AuthorizationCryptoTransactionCryptoTransactionFailed CryptoTransactionFailed { get; set; }

        /// <summary>
        /// The crypto transaction variant for this array entry.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
