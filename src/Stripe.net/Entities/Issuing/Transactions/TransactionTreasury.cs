// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionTreasury : StripeEntity<TransactionTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/received_credits">ReceivedCredit</a>
        /// representing this Issuing transaction if it is a refund.
        /// </summary>
        [JsonProperty("received_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit")]
#endif
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://stripe.com/docs/api/treasury/received_debits">ReceivedDebit</a>
        /// representing this Issuing transaction if it is a capture.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
