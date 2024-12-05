// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitLinkedFlows : StripeEntity<ReceivedDebitLinkedFlows>
    {
        /// <summary>
        /// The DebitReversal created as a result of this ReceivedDebit being reversed.
        /// </summary>
        [JsonProperty("debit_reversal")]
        public string DebitReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is associated with an InboundTransfer's return of funds.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to an <a
        /// href="https://stripe.com/docs/api#issuing_authorizations">Issuing Authorization</a>
        /// object.
        /// </summary>
        [JsonProperty("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is also viewable as an <a
        /// href="https://stripe.com/docs/api#issuing_disputes">Issuing Dispute</a> object.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to a <a
        /// href="https://stripe.com/docs/api#payouts">Payout</a> object.
        /// </summary>
        [JsonProperty("payout")]
        public string Payout { get; set; }
    }
}
