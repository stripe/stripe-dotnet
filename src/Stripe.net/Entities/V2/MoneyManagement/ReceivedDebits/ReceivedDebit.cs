// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// ReceivedDebit resource.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebit : StripeEntity<ReceivedDebit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the ReceivedDebit.
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
        /// Amount and currency of the ReceivedDebit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// This object stores details about the originating banking transaction that resulted in
        /// the ReceivedDebit. Present if <c>type</c> field value is <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public ReceivedDebitBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The time at which the ReceivedDebit was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Freeform string sent by the originator of the ReceivedDebit.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Financial Account on which funds for ReceivedDebit were debited.
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
        /// A link to the Stripe-hosted receipt for this ReceivedDebit.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Open Enum. The status of the ReceivedDebit.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>returned</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Detailed information about the status of the ReceivedDebit.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ReceivedDebitStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The time at which the ReceivedDebit transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public ReceivedDebitStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Open Enum. The type of the ReceivedDebit.
        /// One of: <c>bank_transfer</c>, or <c>external_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
