// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Use ReceivedCredits API to retrieve information on when, where, and how funds are sent
    /// into your FinancialAccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCredit : StripeEntity<ReceivedCredit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the ReceivedCredit.
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
        /// The amount and currency of the ReceivedCredit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// This object stores details about the originating Stripe transaction that resulted in the
        /// ReceivedCredit. Present if <c>type</c> field value is <c>balance_transfer</c>.
        /// </summary>
        [JsonProperty("balance_transfer")]
        [STJS.JsonPropertyName("balance_transfer")]
        public ReceivedCreditBalanceTransfer BalanceTransfer { get; set; }

        /// <summary>
        /// This object stores details about the originating banking transaction that resulted in
        /// the ReceivedCredit. Present if <c>type</c> field value is <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public ReceivedCreditBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// Time at which the ReceivedCredit was created. Represented as a RFC 3339 date &amp; time
        /// UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Freeform string set by originator of the ReceivedCredit.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Financial Account ID on which funds for ReceivedCredit were received.
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
        /// A hosted transaction receipt URL that is provided when money movement is considered
        /// regulated under Stripe’s money transmission licenses.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Open Enum. The status of the ReceivedCredit.
        /// One of: <c>failed</c>, <c>pending</c>, <c>returned</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// This hash contains detailed information that elaborates on the specific status of the
        /// ReceivedCredit. e.g the reason behind a failure if the status is marked as
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ReceivedCreditStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public ReceivedCreditStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Open Enum. The type of flow that caused the ReceivedCredit.
        /// One of: <c>balance_transfer</c>, <c>bank_transfer</c>, or <c>external_credit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
