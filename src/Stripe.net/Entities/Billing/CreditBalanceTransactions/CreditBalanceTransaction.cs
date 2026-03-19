// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A credit balance transaction is a resource representing a transaction (either a credit
    /// or a debit) against an existing credit grant.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceTransaction : StripeEntity<CreditBalanceTransaction>, IHasId, IHasObject
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

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Credit details for this credit balance transaction. Only present if type is
        /// <c>credit</c>.
        /// </summary>
        [JsonProperty("credit")]
        [STJS.JsonPropertyName("credit")]
        public CreditBalanceTransactionCredit Credit { get; set; }

        #region Expandable CreditGrant

        /// <summary>
        /// (ID of the CreditGrant)
        /// The credit grant associated with this credit balance transaction.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CreditGrantId
        {
            get => this.InternalCreditGrant?.Id;
            set => this.InternalCreditGrant = SetExpandableFieldId(value, this.InternalCreditGrant);
        }

        /// <summary>
        /// (Expanded)
        /// The credit grant associated with this credit balance transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public CreditGrant CreditGrant
        {
            get => this.InternalCreditGrant?.ExpandedObject;
            set => this.InternalCreditGrant = SetExpandableFieldObject(value, this.InternalCreditGrant);
        }

        [JsonProperty("credit_grant")]
        [JsonConverter(typeof(ExpandableFieldConverter<CreditGrant>))]
        [STJS.JsonPropertyName("credit_grant")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CreditGrant>))]
        internal ExpandableField<CreditGrant> InternalCreditGrant { get; set; }
        #endregion

        /// <summary>
        /// Debit details for this credit balance transaction. Only present if type is <c>debit</c>.
        /// </summary>
        [JsonProperty("debit")]
        [STJS.JsonPropertyName("debit")]
        public CreditBalanceTransactionDebit Debit { get; set; }

        /// <summary>
        /// The effective time of this credit balance transaction.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this credit balance transaction belongs to.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this credit balance transaction belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        [STJS.JsonPropertyName("test_clock")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion

        /// <summary>
        /// The type of credit balance transaction (credit or debit).
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
