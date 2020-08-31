namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntent : StripeEntity<SetupIntent>, IHasId, IHasMetadata, IHasObject
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

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the SetupIntent.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that created the SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// Reason for cancellation of this SetupIntent, one of <c>abandoned</c>,
        /// <c>requested_by_customer</c>, or <c>duplicate</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// The client secret of this SetupIntent. Used for client-side retrieval using a
        /// publishable key.
        ///
        /// The client secret can be used to complete payment setup from your frontend. It should
        /// not be stored, logged, embedded in URLs, or exposed to anyone other than the customer.
        /// Make sure that you have TLS enabled on any page that includes the client secret.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The error encountered in the previous SetupIntent confirmation.
        /// </summary>
        [JsonProperty("last_setup_error")]
        public StripeError LastSetupError { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Mandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the multi use Mandate generated by the SetupIntent.
        /// </summary>
        [JsonIgnore]
        public string MandateId
        {
            get => this.InternalMandate?.Id;
            set => this.InternalMandate = SetExpandableFieldId(value, this.InternalMandate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the multi use Mandate generated by the SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Mandate Mandate
        {
            get => this.InternalMandate?.ExpandedObject;
            set => this.InternalMandate = SetExpandableFieldObject(value, this.InternalMandate);
        }

        [JsonProperty("mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
        internal ExpandableField<Mandate> InternalMandate { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If present, this property tells you what actions you need to take in order for your
        /// customer to continue payment setup.
        /// </summary>
        [JsonProperty("next_action")]
        public SetupIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) for which the setup is intended.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) for which the setup is intended.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method used with this SetupIntent.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method used with this SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// Payment-method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this SetupIntent is allowed to set up.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        #region Expandable SingleUseMandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the single_use Mandate generated by the SetupIntent.
        /// </summary>
        [JsonIgnore]
        public string SingleUseMandateId
        {
            get => this.InternalSingleUseMandate?.Id;
            set => this.InternalSingleUseMandate = SetExpandableFieldId(value, this.InternalSingleUseMandate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the single_use Mandate generated by the SetupIntent.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Mandate SingleUseMandate
        {
            get => this.InternalSingleUseMandate?.ExpandedObject;
            set => this.InternalSingleUseMandate = SetExpandableFieldObject(value, this.InternalSingleUseMandate);
        }

        [JsonProperty("single_use_mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
        internal ExpandableField<Mandate> InternalSingleUseMandate { get; set; }
        #endregion

        /// <summary>
        /// <a href="https://stripe.com/docs/payments/intents#intent-statuses">Status</a> of this
        /// SetupIntent, one of <c>requires_payment_method</c>, <c>requires_confirmation</c>,
        /// <c>requires_action</c>, <c>processing</c>, <c>canceled</c>, or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_action</c>,
        /// <c>requires_confirmation</c>, <c>requires_payment_method</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Indicates how the payment method is intended to be used in the future.
        ///
        /// Use <c>on_session</c> if you intend to only reuse the payment method when the customer
        /// is in your checkout flow. Use <c>off_session</c> if your customer may or may not be in
        /// your checkout flow. If not provided, this value defaults to <c>off_session</c>.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
