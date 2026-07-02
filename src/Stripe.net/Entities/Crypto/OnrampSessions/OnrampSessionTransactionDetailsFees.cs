// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampSessionTransactionDetailsFees : StripeEntity<OnrampSessionTransactionDetailsFees>
    {
        /// <summary>
        /// The cost associated with moving crypto from Stripe to the end consumer's wallet. e.g:
        /// for ETH, this is called 'gas fee', for BTC this is a 'miner's fee'.
        /// </summary>
        [JsonProperty("network_fee_amount")]
        [STJS.JsonPropertyName("network_fee_amount")]
        public string NetworkFeeAmount { get; set; }

        /// <summary>
        /// Fee for processing the transaction.
        /// </summary>
        [JsonProperty("transaction_fee_amount")]
        [STJS.JsonPropertyName("transaction_fee_amount")]
        public string TransactionFeeAmount { get; set; }
    }
}
