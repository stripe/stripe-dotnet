namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntent : StripeEntity<PaymentIntent>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("amount_capturable")]
        public long? AmountCapturable { get; set; }

        [JsonProperty("amount_received")]
        public long? AmountReceived { get; set; }

        #region Expandable Application
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication.Id;
            set => this.InternalApplication.Id = value;
        }

        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication.ExpandedObject;
            set => this.InternalApplication.ExpandedObject = value;
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("charges")]
        public StripeList<Charge> Charges { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer.Id;
            set => this.InternalCustomer.Id = value;
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer.ExpandedObject;
            set => this.InternalCustomer.ExpandedObject = value;
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Invoice
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice.Id;
            set => this.InternalInvoice.Id = value;
        }

        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice.ExpandedObject;
            set => this.InternalInvoice.ExpandedObject = value;
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        [JsonProperty("last_payment_error")]
        public StripeError LastPaymentError { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_action")]
        public PaymentIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf (Account)
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf.Id;
            set => this.InternalOnBehalfOf.Id = value;
        }

        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf.ExpandedObject;
            set => this.InternalOnBehalfOf.ExpandedObject = value;
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable PaymentMethod
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod.Id;
            set => this.InternalPaymentMethod.Id = value;
        }

        [JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod.ExpandedObject;
            set => this.InternalPaymentMethod.ExpandedObject = value;
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        #region Expandable Review
        [JsonIgnore]
        public string ReviewId
        {
            get => this.InternalReview.Id;
            set => this.InternalReview.Id = value;
        }

        [JsonIgnore]
        public Review Review
        {
            get => this.InternalReview.ExpandedObject;
            set => this.InternalReview.ExpandedObject = value;
        }

        [JsonProperty("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
        internal ExpandableField<Review> InternalReview { get; set; }
        #endregion

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        #region Expandable Source
        [JsonIgnore]
        public string SourceId
        {
            get => this.InternalSource.Id;
            set => this.InternalSource.Id = value;
        }

        [JsonIgnore]
        public IPaymentSource Source
        {
            get => this.InternalSource.ExpandedObject;
            set => this.InternalSource.ExpandedObject = value;
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalSource { get; set; }
        #endregion

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferData TransferData { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }

        [Obsolete("Use PaymentMethodTypes")]
        [JsonProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }
    }
}
