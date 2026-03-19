// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Some payment methods have no required amount that a customer must send. Customers can be
    /// instructed to send any amount, and it can be made up of multiple transactions. As such,
    /// sources can have multiple associated transactions.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceTransaction : StripeEntity<SourceTransaction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("ach_credit_transfer")]
        [STJS.JsonPropertyName("ach_credit_transfer")]
        public SourceTransactionAchCreditTransfer AchCreditTransfer { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the amount your customer
        /// has pushed to the receiver.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonProperty("chf_credit_transfer")]
        [STJS.JsonPropertyName("chf_credit_transfer")]
        public SourceTransactionChfCreditTransfer ChfCreditTransfer { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("gbp_credit_transfer")]
        [STJS.JsonPropertyName("gbp_credit_transfer")]
        public SourceTransactionGbpCreditTransfer GbpCreditTransfer { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("paper_check")]
        [STJS.JsonPropertyName("paper_check")]
        public SourceTransactionPaperCheck PaperCheck { get; set; }

        [JsonProperty("sepa_credit_transfer")]
        [STJS.JsonPropertyName("sepa_credit_transfer")]
        public SourceTransactionSepaCreditTransfer SepaCreditTransfer { get; set; }

        /// <summary>
        /// The ID of the source this transaction is attached to.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// The status of the transaction, one of <c>succeeded</c>, <c>pending</c>, or
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of source this transaction is attached to.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>alipay</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>klarna</c>, <c>multibanco</c>, <c>p24</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>three_d_secure</c>, or <c>wechat</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
