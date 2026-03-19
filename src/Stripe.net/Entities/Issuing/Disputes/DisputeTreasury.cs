// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeTreasury : StripeEntity<DisputeTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/debit_reversals">DebitReversal</a>
        /// representing this Issuing dispute.
        /// </summary>
        [JsonProperty("debit_reversal")]
        [STJS.JsonPropertyName("debit_reversal")]
        public string DebitReversal { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/received_debits">ReceivedDebit</a> that is
        /// being disputed.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
