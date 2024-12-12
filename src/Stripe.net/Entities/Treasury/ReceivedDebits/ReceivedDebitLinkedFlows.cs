// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitLinkedFlows : StripeEntity<ReceivedDebitLinkedFlows>
    {
        /// <summary>
        /// The DebitReversal created as a result of this ReceivedDebit being reversed.
        /// </summary>
        [JsonProperty("debit_reversal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_reversal")]
#endif
        public string DebitReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is associated with an InboundTransfer's return of funds.
        /// </summary>
        [JsonProperty("inbound_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfer")]
#endif
        public string InboundTransfer { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to an <a
        /// href="https://stripe.com/docs/api#issuing_authorizations">Issuing Authorization</a>
        /// object.
        /// </summary>
        [JsonProperty("issuing_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_authorization")]
#endif
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit is also viewable as an <a
        /// href="https://stripe.com/docs/api#issuing_disputes">Issuing Dispute</a> object.
        /// </summary>
        [JsonProperty("issuing_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_transaction")]
#endif
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// Set if the ReceivedDebit was created due to a <a
        /// href="https://stripe.com/docs/api#payouts">Payout</a> object.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif
        public string Payout { get; set; }

        /// <summary>
        /// The ReceivedCredit that Capital withheld from.
        /// </summary>
        [JsonProperty("received_credit_capital_withholding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit_capital_withholding")]
#endif
        public string ReceivedCreditCapitalWithholding { get; set; }
    }
}
