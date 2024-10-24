// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A credit balance transaction is a resource representing a transaction (either a credit
    /// or a debit) against an existing credit grant.
    /// </summary>
    public class CreditBalanceTransaction : StripeEntity<CreditBalanceTransaction>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Credit details for this credit balance transaction. Only present if type is
        /// <c>credit</c>.
        /// </summary>
        [JsonProperty("credit")]
        public CreditBalanceTransactionCredit Credit { get; set; }

        #region Expandable CreditGrant

        /// <summary>
        /// (ID of the CreditGrant)
        /// The credit grant associated with this credit balance transaction.
        /// </summary>
        [JsonIgnore]
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
        public CreditGrant CreditGrant
        {
            get => this.InternalCreditGrant?.ExpandedObject;
            set => this.InternalCreditGrant = SetExpandableFieldObject(value, this.InternalCreditGrant);
        }

        [JsonProperty("credit_grant")]
        [JsonConverter(typeof(ExpandableFieldConverter<CreditGrant>))]
        internal ExpandableField<CreditGrant> InternalCreditGrant { get; set; }
        #endregion

        /// <summary>
        /// Debit details for this credit balance transaction. Only present if type is <c>debit</c>.
        /// </summary>
        [JsonProperty("debit")]
        public CreditBalanceTransactionDebit Debit { get; set; }

        /// <summary>
        /// The effective time of this credit balance transaction.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this credit balance transaction belongs to.
        /// </summary>
        [JsonIgnore]
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
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion

        /// <summary>
        /// The type of credit balance transaction (credit or debit).
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
