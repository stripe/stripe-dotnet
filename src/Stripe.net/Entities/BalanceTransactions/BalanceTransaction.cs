namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BalanceTransaction : StripeEntity<BalanceTransaction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Gross amount of the transaction, in cents.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The date the transaction's net funds will become available in the Stripe balance.
        /// </summary>
        [JsonProperty("available_on")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime AvailableOn { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The exchange rate associated with this transaction.
        /// </summary>
        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Fees (in cents) paid for this transaction.
        /// </summary>
        [JsonProperty("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// Detailed breakdown of fees (in cents) paid for this transaction.
        /// </summary>
        [JsonProperty("fee_details")]
        public List<BalanceTransactionFeeDetail> FeeDetails { get; set; }

        /// <summary>
        /// Net amount of the transaction, in cents.
        /// </summary>
        [JsonProperty("net")]
        public long Net { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/reports/reporting-categories">Learn more</a>
        /// about how reporting categories can help you understand
        /// balance transactions from an accounting perspective.
        /// </summary>
        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }

        #region Expandable Source

        /// <summary>
        /// The ID of the Stripe object to which this transaction is related.
        /// </summary>
        [JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        [JsonIgnore]
        public IBalanceTransactionSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IBalanceTransactionSource>))]
        internal ExpandableField<IBalanceTransactionSource> InternalSource { get; set; }
        #endregion

        /// <summary>
        /// If the transaction's net funds are available in the Stripe balance
        /// yet. Either <c>available</c> or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Transaction type.
        /// <a href="https://stripe.com/docs/reports/balance-transaction-types">Learn more</a>
        /// about balance transaction types and what they represent.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
