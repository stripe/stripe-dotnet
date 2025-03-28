// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// ReceivedDebit resource.
    /// </summary>
    public class ReceivedDebit : StripeEntity<ReceivedDebit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the ReceivedDebit.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Amount and currency of the ReceivedDebit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// This object stores details about the originating banking transaction that resulted in
        /// the ReceivedDebit. Present if <c>type</c> field value is <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer")]
#endif
        public ReceivedDebitBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// This object stores details about the issuing transactions that resulted in the
        /// ReceivedDebit. Present if <c>type</c> field value is <c>card_spend</c>.
        /// </summary>
        [JsonProperty("card_spend")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_spend")]
#endif
        public ReceivedDebitCardSpend CardSpend { get; set; }

        /// <summary>
        /// The time at which the ReceivedDebit was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Freeform string sent by the originator of the ReceivedDebit.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Financial Account on which funds for ReceivedDebit were debited.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A link to the Stripe-hosted receipt for this ReceivedDebit.
        /// </summary>
        [JsonProperty("receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_url")]
#endif
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Open Enum. The status of the ReceivedDebit.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>returned</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Detailed information about the status of the ReceivedDebit.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public ReceivedDebitStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The time at which the ReceivedDebit transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public ReceivedDebitStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Open Enum. The type of the ReceivedDebit.
        /// One of: <c>bank_transfer</c>, <c>card_spend</c>, or <c>external_debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
