// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionTreasury : StripeEntity<TransactionTreasury>
    {
        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/received_credits">ReceivedCredit</a>
        /// representing this Issuing transaction if it is a refund.
        /// </summary>
        [JsonProperty("received_credit")]
        [STJS.JsonPropertyName("received_credit")]
        public string ReceivedCredit { get; set; }

        /// <summary>
        /// The Treasury <a
        /// href="https://docs.stripe.com/api/treasury/received_debits">ReceivedDebit</a>
        /// representing this Issuing transaction if it is a capture.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
