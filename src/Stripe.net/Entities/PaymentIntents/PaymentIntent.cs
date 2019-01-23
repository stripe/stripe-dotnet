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
        public string ApplicationId { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }

        [JsonProperty("application")]
        internal object InternalApplication
        {
            get
            {
                return this.Application ?? (object)this.ApplicationId;
            }

            set
            {
                StringOrObject<Application>.Map(value, s => this.ApplicationId = s, o => this.Application = o);
            }
        }
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
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Invoice
        [JsonIgnore]
        public string InvoiceId { get; set; }

        [JsonIgnore]
        public Invoice Invoice { get; set; }

        [JsonProperty("invoice")]
        internal object InternalInvoice
        {
            get
            {
                return this.Invoice ?? (object)this.InvoiceId;
            }

            set
            {
                StringOrObject<Invoice>.Map(value, s => this.InvoiceId = s, o => this.Invoice = o);
            }
        }
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
        public string OnBehalfOfId { get; set; }

        [JsonIgnore]
        public Account OnBehalfOf { get; set; }

        [JsonProperty("on_behalf_of")]
        internal object InternalOnBehalfOf
        {
            get
            {
                return this.OnBehalfOf ?? (object)this.OnBehalfOfId;
            }

            set
            {
                StringOrObject<Account>.Map(value, s => this.OnBehalfOfId = s, o => this.OnBehalfOf = o);
            }
        }
        #endregion

        #region Expandable PaymentMethod
        [JsonIgnore]
        public string PaymentMethodId { get; set; }

        [JsonIgnore]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("payment_method")]
        internal object InternalPaymentMethod
        {
            get
            {
                return this.PaymentMethod ?? (object)this.PaymentMethodId;
            }

            set
            {
                StringOrObject<PaymentMethod>.Map(value, s => this.PaymentMethodId = s, o => this.PaymentMethod = o);
            }
        }
        #endregion

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        #region Expandable Review
        [JsonIgnore]
        public string ReviewId { get; set; }

        [JsonIgnore]
        public Review Review { get; set; }

        [JsonProperty("review")]
        internal object InternalReview
        {
            get
            {
                return this.Review ?? (object)this.ReviewId;
            }

            set
            {
                StringOrObject<Review>.Map(value, s => this.ReviewId = s, o => this.Review = o);
            }
        }
        #endregion

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        #region Expandable Source
        [JsonIgnore]
        public string SourceId { get; set; }

        [JsonIgnore]
        public IPaymentSource Source { get; set; }

        [JsonProperty("source")]
        internal object InternalSource
        {
            get
            {
                return this.Source ?? (object)this.SourceId;
            }

            set
            {
                StringOrObject<IPaymentSource>.Map(value, s => this.SourceId = s, o => this.Source = o);
            }
        }
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
