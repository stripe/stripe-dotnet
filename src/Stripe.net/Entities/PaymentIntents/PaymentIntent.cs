// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A PaymentIntent guides you through the process of collecting a payment from your
    /// customer. We recommend that you create exactly one PaymentIntent for each order or
    /// customer session in your system. You can reference the PaymentIntent later to see the
    /// history of payment attempts for a particular session.
    ///
    /// A PaymentIntent transitions through <a
    /// href="https://stripe.com/docs/payments/intents#intent-statuses">multiple statuses</a>
    /// throughout its lifetime as it interfaces with Stripe.js to perform authentication flows
    /// and ultimately creates at most one successful charge.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payments/payment-intents">Payment
    /// Intents API</a>.
    /// </summary>
    public class PaymentIntent : StripeEntity<PaymentIntent>, IHasId, IHasMetadata, IHasObject
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
        /// Amount intended to be collected by this PaymentIntent. A positive integer representing
        /// how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount that can be captured from this PaymentIntent.
        /// </summary>
        [JsonProperty("amount_capturable")]
        public long AmountCapturable { get; set; }

        /// <summary>
        /// Amount that was collected by this PaymentIntent.
        /// </summary>
        [JsonProperty("amount_received")]
        public long AmountReceived { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that created the PaymentIntent.
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
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total payment amount. For more
        /// information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Settings to configure compatible payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
        public PaymentIntentAutomaticPaymentMethods AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Populated when <c>status</c> is <c>canceled</c>, this is the time at which the
        /// PaymentIntent was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for cancellation of this PaymentIntent, either user-provided (<c>duplicate</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>abandoned</c>) or generated by
        /// Stripe internally (<c>failed_invoice</c>, <c>void_invoice</c>, or <c>automatic</c>).
        /// One of: <c>abandoned</c>, <c>automatic</c>, <c>duplicate</c>, <c>failed_invoice</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>void_invoice</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Charges that were created by this PaymentIntent, if any.
        /// </summary>
        [JsonProperty("charges")]
        public StripeList<Charge> Charges { get; set; }

        /// <summary>
        /// The client secret of this PaymentIntent. Used for client-side retrieval using a
        /// publishable key.
        ///
        /// The client secret can be used to complete a payment from your frontend. It should not be
        /// stored, logged, embedded in URLs, or exposed to anyone other than the customer. Make
        /// sure that you have TLS enabled on any page that includes the client secret.
        ///
        /// Refer to our docs to <a
        /// href="https://stripe.com/docs/payments/accept-a-payment?integration=elements">accept a
        /// payment</a> and learn about how <c>client_secret</c> should be handled.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        ///
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If present in combination with <a
        /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>,
        /// this PaymentIntent's payment method will be attached to the Customer after the
        /// PaymentIntent has been confirmed and any required actions from the user are complete.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        ///
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If present in combination with <a
        /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>,
        /// this PaymentIntent's payment method will be attached to the Customer after the
        /// PaymentIntent has been confirmed and any required actions from the user are complete.
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

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice that created this PaymentIntent, if it exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the invoice that created this PaymentIntent, if it exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// The payment error encountered in the previous PaymentIntent confirmation. It will be
        /// cleared if the PaymentIntent is later updated for any reason.
        /// </summary>
        [JsonProperty("last_payment_error")]
        public StripeError LastPaymentError { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. For more information, see the <a
        /// href="https://stripe.com/docs/payments/payment-intents/creating-payment-intents#storing-information-in-metadata">documentation</a>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If present, this property tells you what actions you need to take in order for your
        /// customer to fulfill a payment using the provided source.
        /// </summary>
        [JsonProperty("next_action")]
        public PaymentIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) for which the funds of the PaymentIntent are intended. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/connected-accounts">use case
        /// for connected accounts</a> for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account (if any) for which the funds of the PaymentIntent are intended. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/connected-accounts">use case
        /// for connected accounts</a> for details.
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
        /// ID of the payment method used in this PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method used in this PaymentIntent.
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
        /// Payment-method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this PaymentIntent is allowed to use.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        #region Expandable Review

        /// <summary>
        /// (ID of the Review)
        /// ID of the review associated with this PaymentIntent, if any.
        /// </summary>
        [JsonIgnore]
        public string ReviewId
        {
            get => this.InternalReview?.Id;
            set => this.InternalReview = SetExpandableFieldId(value, this.InternalReview);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the review associated with this PaymentIntent, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Review Review
        {
            get => this.InternalReview?.ExpandedObject;
            set => this.InternalReview = SetExpandableFieldObject(value, this.InternalReview);
        }

        [JsonProperty("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
        internal ExpandableField<Review> InternalReview { get; set; }
        #endregion

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        #region Expandable Source

        /// <summary>
        /// (ID of the IPaymentSource)
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object that is associated with this PaymentIntent, if one was supplied.
        /// </summary>
        [JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        /// <summary>
        /// (Expanded)
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object that is associated with this PaymentIntent, if one was supplied.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public IPaymentSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalSource { get; set; }
        #endregion

        /// <summary>
        /// For non-card charges, you can use this value as the complete description that appears on
        /// your customers’ statements. Must contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Status of this PaymentIntent, one of <c>requires_payment_method</c>,
        /// <c>requires_confirmation</c>, <c>requires_action</c>, <c>processing</c>,
        /// <c>requires_capture</c>, <c>canceled</c>, or <c>succeeded</c>. Read more about each
        /// PaymentIntent <a
        /// href="https://stripe.com/docs/payments/intents#intent-statuses">status</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_action</c>,
        /// <c>requires_capture</c>, <c>requires_confirmation</c>, <c>requires_payment_method</c>,
        /// or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer when the payment is finalized.
        /// See the PaymentIntents <a href="https://stripe.com/docs/payments/connected-accounts">use
        /// case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/connected-accounts">use case
        /// for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
