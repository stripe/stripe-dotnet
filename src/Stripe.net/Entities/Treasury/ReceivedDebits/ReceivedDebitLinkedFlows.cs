// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitLinkedFlows : StripeEntity<ReceivedDebitLinkedFlows>
    {
        /// <summary>
        /// The DebitReversal created as a result of this ReceivedDebit being reversed.
        /// </summary>
        [JsonProperty("debit_reversal")]
        [STJS.JsonPropertyName("debit_reversal")]
        public string DebitReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is associated with an InboundTransfer's return of funds.
        /// </summary>
        [JsonProperty("inbound_transfer")]
        [STJS.JsonPropertyName("inbound_transfer")]
        public string InboundTransfer { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to an <a
        /// href="https://api.stripe.com#issuing_authorizations">Issuing Authorization</a> object.
        /// </summary>
        [JsonProperty("issuing_authorization")]
        [STJS.JsonPropertyName("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is also viewable as an <a
        /// href="https://api.stripe.com#issuing_disputes">Issuing Dispute</a> object.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        [STJS.JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to a <a
        /// href="https://api.stripe.com#payouts">Payout</a> object.
        /// </summary>
        [JsonProperty("payout")]
        [STJS.JsonPropertyName("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// The ReceivedCredit that Capital withheld from.
        /// </summary>
        [JsonProperty("received_credit_capital_withholding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit_capital_withholding")]
#endif
        public string ReceivedCreditCapitalWithholding { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to a <a
        /// href="https://api.stripe.com#topups">Topup</a> object.
        /// </summary>
        [JsonProperty("topup")]
        [STJS.JsonPropertyName("topup")]
        public string Topup { get; set; }
    }
}
