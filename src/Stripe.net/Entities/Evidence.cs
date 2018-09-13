namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Evidence : StripeEntity
    {
        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        #region Expandable Cancellation Policy
        public string CancellationPolicyFileId { get; set; }

        [JsonIgnore]
        public FileUpload CancellationPolicyFile { get; set; }

        [JsonProperty("cancellation_policy")]
        internal object InternalCancellationPolicy
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.CancellationPolicyFileId = s, o => this.CancellationPolicyFile = o);
            }
        }
        #endregion

        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        #region Expandable Customer Communication
        public string CustomerCommunicationFileId { get; set; }

        [JsonIgnore]
        public FileUpload CustomerCommunicationFile { get; set; }

        [JsonProperty("customer_communication")]
        internal object InternalCustomerCommunication
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.CustomerCommunicationFileId = s, o => this.CustomerCommunicationFile = o);
            }
        }
        #endregion

        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIPAddress { get; set; }

        #region Expandable Customer Signature
        public string CustomerSignatureFileId { get; set; }

        [JsonIgnore]
        public FileUpload CustomerSignatureFile { get; set; }

        [JsonProperty("customer_signature")]
        internal object InternalCustomerSignatureFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.CustomerSignatureFileId = s, o => this.CustomerSignatureFile = o);
            }
        }
        #endregion

        #region Expandable Duplicate Charge Documentation
        public string DuplicateChargeDocumentationFileId { get; set; }

        [JsonIgnore]
        public FileUpload DuplicateChargeDocumentationFile { get; set; }

        [JsonProperty("duplicate_charge_documentation")]
        internal object InternalDuplicateChargeDocumentationFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.DuplicateChargeDocumentationFileId = s, o => this.DuplicateChargeDocumentationFile = o);
            }
        }
        #endregion

        [JsonProperty("duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [JsonProperty("duplicate_charge_id")]
        public string DuplicateChargeId { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        #region Expandable Receipt
        public string ReceiptFileId { get; set; }

        [JsonIgnore]
        public FileUpload ReceiptFile { get; set; }

        [JsonProperty("receipt")]
        internal object InternalReceiptFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.ReceiptFileId = s, o => this.ReceiptFile = o);
            }
        }
        #endregion

        #region Expandable Refund Policy
        public string RefundPolicyFileId { get; set; }

        [JsonIgnore]
        public FileUpload RefundPolicyFile { get; set; }

        [JsonProperty("refund_policy")]
        internal object InternalRefundPolicyFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.RefundPolicyFileId = s, o => this.RefundPolicyFile = o);
            }
        }
        #endregion

        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        #region Expandable Service Documentation
        public string ServiceDocumentationFileId { get; set; }

        [JsonIgnore]
        public FileUpload ServiceDocumentationFile { get; set; }

        [JsonProperty("service_documentation")]
        internal object InternalServiceDocumentationFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.ServiceDocumentationFileId = s, o => this.ServiceDocumentationFile = o);
            }
        }
        #endregion

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("shipping_date")]
        public string ShippingDate { get; set; }

        #region Expandable Shipping Documentation
        public string ShippingDocumentationFileId { get; set; }

        [JsonIgnore]
        public FileUpload ShippingDocumentationFile { get; set; }

        [JsonProperty("shipping_documentation")]
        internal object InternalShippingDocumentationFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.ShippingDocumentationFileId = s, o => this.ShippingDocumentationFile = o);
            }
        }
        #endregion

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        #region Expandable Uncategorized File
        public string UncategorizedFileId { get; set; }

        [JsonIgnore]
        public FileUpload UncategorizedFile { get; set; }

        [JsonProperty("uncategorized_file")]
        internal object InternalUncategorizedFile
        {
            set
            {
                StringOrObject<FileUpload>.Map(value, s => this.UncategorizedFileId = s, o => this.UncategorizedFile = o);
            }
        }
        #endregion

        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}