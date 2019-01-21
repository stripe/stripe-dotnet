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
        public string ApplicationId => this.InternalApplication.Id;

        [JsonIgnore]
        public Application Application => this.InternalApplication.ExpandedObject;

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
        public string CustomerId => this.InternalCustomer.Id;

        [JsonIgnore]
        public Customer Customer => this.InternalCustomer.ExpandedObject;

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Invoice
        [JsonIgnore]
        public string InvoiceId => this.InternalInvoice.Id;

        [JsonIgnore]
        public Invoice Invoice => this.InternalInvoice.ExpandedObject;

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
        public string OnBehalfOfId => this.InternalOnBehalfOf.Id;

        [JsonIgnore]
        public Account OnBehalfOf => this.InternalOnBehalfOf.ExpandedObject;

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable PaymentMethod
        [JsonIgnore]
        public string PaymentMethodId => this.InternalPaymentMethod.Id;

        [JsonIgnore]
        public PaymentMethod PaymentMethod => this.InternalPaymentMethod.ExpandedObject;

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
        public string ReviewId => this.InternalReview.Id;

        [JsonIgnore]
        public Review Review => this.InternalReview.ExpandedObject;

        [JsonProperty("review")]
        [JsonConverter(typeof(ExpandableFieldConverter<Review>))]
        internal ExpandableField<Review> InternalReview { get; set; }
        #endregion

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        #region Expandable Source
        [JsonIgnore]
        public string SourceId => this.InternalSource.Id;

        [JsonIgnore]
        public IPaymentSource Source => this.InternalSource.ExpandedObject;

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
