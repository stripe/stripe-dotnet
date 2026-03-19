// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A credit grant is an API resource that documents the allocation of some billing credits
    /// to a customer.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/billing/subscriptions/usage-based/billing-credits">Billing
    /// credits</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditGrant : StripeEntity<CreditGrant>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public CreditGrantAmount Amount { get; set; }

        [JsonProperty("applicability_config")]
        [STJS.JsonPropertyName("applicability_config")]
        public CreditGrantApplicabilityConfig ApplicabilityConfig { get; set; }

        /// <summary>
        /// The category of this credit grant. This is for tracking purposes and isn't displayed to
        /// the customer.
        /// One of: <c>paid</c>, or <c>promotional</c>.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer receiving the billing credits.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer receiving the billing credits.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// ID of the account representing the customer receiving the billing credits.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The time when the billing credits become effective-when they're eligible for use.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The time when the billing credits expire. If not present, the billing credits don't
        /// expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A descriptive name shown in dashboard.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The priority for applying this credit grant. The highest priority is 0 and the lowest is
        /// 100.
        /// </summary>
        [JsonProperty("priority")]
        [STJS.JsonPropertyName("priority")]
        public long? Priority { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this credit grant belongs to.
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
        /// ID of the test clock this credit grant belongs to.
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
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("updated")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time when this credit grant was voided. If not present, the credit grant hasn't been
        /// voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("voided_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? VoidedAt { get; set; }
    }
}
