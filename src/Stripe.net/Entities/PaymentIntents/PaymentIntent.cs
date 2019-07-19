namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntent : StripeEntity<PaymentIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount intended to be collected by this PaymentIntent.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Amount that can be captured from this PaymentIntent.
        /// </summary>
        [JsonProperty("amount_capturable")]
        public long? AmountCapturable { get; set; }

        /// <summary>
        /// Amount that was collected by this PaymentIntent.
        /// </summary>
        [JsonProperty("amount_received")]
        public long? AmountReceived { get; set; }

        #region Expandable Application

        /// <summary>
        /// ID of the Connect application that created the PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

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
        /// The amount of the application fee (if any) for the resulting payment. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Populated when status is <c>canceled</c>, this is the time at which the PaymentIntent
        /// was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for cancellation of this PaymentIntent, either user-provided (<c>duplicate</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>abandoned</c>) or generated by
        /// Stripe internally (<c>failed_invoice</c>, <c>void_invoice</c>, or <c>automatic</c>).
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// One of <c>automatic</c> (default) or <c>manual</c>.
        /// When the capture method is <c>automatic</c>, Stripe automatically captures funds when
        /// the customer authorizes the payment.
        /// Change the capture method to <c>manual</c> if you wish to <a href="https://stripe.com/docs/payments/payment-intents/quickstart#automatic-confirmation-flow">
        /// separate authorization and capture</a> for payment methods that support this.
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
        /// The client secret can be used to complete a payment from your frontend. It should not
        /// be stored, logged, embedded in URLs, or exposed to anyone other than the customer. Make
        /// sure that you have TLS enabled on any page that includes the client secret.
        /// Please refer to our <a href="https://stripe.com/docs/payments/payment-intents/quickstart#automatic-confirmation-flow">
        /// automatic confirmation quickstart guide</a> to learn about how client_secret should be
        /// handled.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// One of <c>automatic</c> (default) or <c>manual</c>.
        /// When the confirmation method is <c>automatic</c>, a PaymentIntent can be confirmed
        /// using a publishable key. After next actions are handled, no additional confirmation is
        /// required to complete the payment.
        /// When the confirmation method is <c>manual</c>, all payment attempts must be made using
        /// a secret key. The PaymentIntent returns to the requires_confirmation state after
        /// handling next_actions, and requires your server to initiate each payment attempt with
        /// an explicit confirmation.
        /// </summary>
        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        /// If present, payment methods used with this PaymentIntent can only be attached to this
        /// Customer, and payment methods attached to other Customers cannot be used with this
        /// PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

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
        /// ID of the invoice that created this PaymentIntent, if one exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

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
        /// The payment error encountered in the previous PaymentIntent confirmation.
        /// </summary>
        [JsonProperty("last_payment_error")]
        public StripeError LastPaymentError { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for
        /// storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If present, this property tells you what actions you need to take in order for your
        /// customer to fulfill a payment using the provided source.
        /// </summary>
        [JsonProperty("next_action")]
        public PaymentIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf (Account)

        /// <summary>
        /// The account (if any) for which the funds of the PaymentIntent are intended.
        /// See the PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

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
        /// ID of the payment method used in this PaymentIntent.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

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
        /// Email address that the receipt for the resulting payment will be sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        #region Expandable Review

        /// <summary>
        /// ID of the review associated with this PaymentIntent, if any.
        /// </summary>
        [JsonIgnore]
        public string ReviewId
        {
            get => this.InternalReview?.Id;
            set => this.InternalReview = SetExpandableFieldId(value, this.InternalReview);
        }

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
        /// Indicates that you intend to make future payments with this PaymentIntent’s payment
        /// method.
        /// If present, the payment method used with this PaymentIntent can be attached to a
        /// Customer, even after the transaction completes.
        /// Use <c>on_session</c> if you intend to only reuse the payment method when your customer
        /// is present in your checkout flow. Use <c>off_session</c> if your customer may or may
        /// not be in your checkout flow.
        /// Stripe uses this to dynamically optimize your payment flow and comply with regional
        /// legislation and network rules. For example, if your customer is impacted by SCA, using
        /// <c>off_session</c> will ensure that they are authenticated while processing this
        /// PaymentIntent. You will then be able to make later off-session payments for this
        /// customer.
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
        /// ID of the Source associated with this PaymentIntent, if any.
        /// </summary>
        [JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

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
        /// Extra information about a PaymentIntent. This will appear on your customer’s statement
        /// when this PaymentIntent succeeds in creating a charge
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
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
        /// PaymentIntent <a href="https://stripe.com/docs/payments/intents#intent-statuses">status</a>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer when the payment is finalized.
        /// See the PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferData TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
