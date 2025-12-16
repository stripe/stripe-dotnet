// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeTreasury : StripeEntity<DisputeTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/debit_reversals">DebitReversal</a>
        /// representing this Issuing dispute.
        /// </summary>
        [JsonProperty("debit_reversal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_reversal")]
#endif
        public string DebitReversal { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/received_debits">ReceivedDebit</a> that is
        /// being disputed.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
