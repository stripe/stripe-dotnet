// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A DebitDispute represents a dispute raised against a received debit.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitDispute : StripeEntity<DebitDispute>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of a DebitDispute.
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
        /// The amount of the DebitDispute.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Details about the bank transfer dispute. Present if <c>type</c> field value is
        /// <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public DebitDisputeBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// Time at which the DebitDispute was created. Represented as a RFC 3339 date &amp; time
        /// UTC value in millisecond precision, for example: <c>2026-03-23T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The Financial Account associated with the DebitDispute.
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
        /// The ID of the ReceivedDebit that was disputed.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// The status of the DebitDispute.
        /// One of: <c>failed</c>, <c>submitted</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Detailed information about the status of the DebitDispute.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public DebitDisputeStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// The time at which the DebitDispute transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public DebitDisputeStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The type of the DebitDispute.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
