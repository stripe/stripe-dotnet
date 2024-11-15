// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Some payment methods have no required amount that a customer must send. Customers can be
    /// instructed to send any amount, and it can be made up of multiple transactions. As such,
    /// sources can have multiple associated transactions.
    /// </summary>
    public class SourceTransaction : StripeEntity<SourceTransaction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        [JsonProperty("ach_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_credit_transfer")]
#endif

        public SourceTransactionAchCreditTransfer AchCreditTransfer { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the amount your customer
        /// has pushed to the receiver.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long Amount { get; set; }

        [JsonProperty("chf_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("chf_credit_transfer")]
#endif

        public SourceTransactionChfCreditTransfer ChfCreditTransfer { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        [JsonProperty("gbp_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gbp_credit_transfer")]
#endif

        public SourceTransactionGbpCreditTransfer GbpCreditTransfer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        [JsonProperty("paper_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paper_check")]
#endif

        public SourceTransactionPaperCheck PaperCheck { get; set; }

        [JsonProperty("sepa_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_credit_transfer")]
#endif

        public SourceTransactionSepaCreditTransfer SepaCreditTransfer { get; set; }

        /// <summary>
        /// The ID of the source this transaction is attached to.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif

        public string Source { get; set; }

        /// <summary>
        /// The status of the transaction, one of <c>succeeded</c>, <c>pending</c>, or
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The type of source this transaction is attached to.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>alipay</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>klarna</c>, <c>multibanco</c>, <c>p24</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>three_d_secure</c>, or <c>wechat</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
