// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A ReceivedDebitMandate represents an authorization from a third party to debit a
    /// financial account on a recurring basis.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitMandate : StripeEntity<ReceivedDebitMandate>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier for the ReceivedDebitMandate.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// This object stores details about the originating bank transfer that resulted in the
        /// ReceivedDebitMandate. Present if <c>type</c> field value is <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public ReceivedDebitMandateBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The time at which the ReceivedDebitMandate was created. Represented as a RFC 3339 date
        /// &amp; time UTC value in millisecond precision, for example:
        /// <c>2026-06-03T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency of the ReceivedDebitMandate in ISO 4217 format. This is the currency that
        /// debits will be collected in.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Financial account ID associated with this mandate.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the ReceivedDebitMandate.
        /// One of: <c>active</c>, <c>canceled</c>, <c>expired</c>, or <c>pending_cancellation</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Detailed information that elaborates on the specific status of the ReceivedDebitMandate.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ReceivedDebitMandateStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Timestamps describing when the mandate changed status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public ReceivedDebitMandateStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The type of the ReceivedDebitMandate.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
