namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntent : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("amount_capturable")]
        public int? AmountCapturable { get; set; }

        [JsonProperty("amount_received")]
        public int? AmountReceived { get; set; }

        #region Expandable Application
        public string ApplicationId { get; set; }

        [JsonIgnore]
        public StripeApplication Application { get; set; }

        [JsonProperty("application")]
        internal object InternalApplication
        {
            set
            {
                StringOrObject<StripeApplication>.Map(value, s => this.ApplicationId = s, o => this.Application = o);
            }
        }
        #endregion

        [JsonProperty("application_fee_amount")]
        public int? ApplicationFeeAmount { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("charges")]
        public StripeList<StripeCharge> Charges { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<StripeCustomer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_source_action")]
        public PaymentIntentSourceAction NextSourceAction { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        #region Expandable Review
        public string ReviewId { get; set; }

        [JsonIgnore]
        public StripeReview Review { get; set; }

        [JsonProperty("review")]
        internal object InternalReview
        {
            set
            {
                StringOrObject<StripeReview>.Map(value, s => this.ReviewId = s, o => this.Review = o);
            }
        }
        #endregion

        [JsonProperty("shipping")]
        public StripeShipping Shipping { get; set; }

        #region Expandable Source
        public string SourceId { get; set; }

        [JsonIgnore]
        public Source Source { get; set; }

        [JsonProperty("source")]
        internal object InternalSource
        {
            set
            {
                StringOrObject<Source>.Map(value, s => this.SourceId = s, o => this.Source = o);
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
    }
}
