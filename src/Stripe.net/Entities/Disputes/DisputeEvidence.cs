namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidence : StripeEntity<DisputeEvidence>
    {
        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        #region Expandable CancellationPolicy

        [JsonIgnore]
        public string CancellationPolicyId
        {
            get => this.InternalCancellationPolicy?.Id;
            set => this.InternalCancellationPolicy = SetExpandableFieldId(value, this.InternalCancellationPolicy);
        }

        [JsonIgnore]
        public File CancellationPolicy
        {
            get => this.InternalCancellationPolicy?.ExpandedObject;
            set => this.InternalCancellationPolicy = SetExpandableFieldObject(value, this.InternalCancellationPolicy);
        }

        [JsonProperty("cancellation_policy")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCancellationPolicy { get; set; }
        #endregion

        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        #region Expandable CustomerCommunication

        [JsonIgnore]
        public string CustomerCommunicationId
        {
            get => this.InternalCustomerCommunication?.Id;
            set => this.InternalCustomerCommunication = SetExpandableFieldId(value, this.InternalCustomerCommunication);
        }

        [JsonIgnore]
        public File CustomerCommunication
        {
            get => this.InternalCustomerCommunication?.ExpandedObject;
            set => this.InternalCustomerCommunication = SetExpandableFieldObject(value, this.InternalCustomerCommunication);
        }

        [JsonProperty("customer_communication")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCustomerCommunication { get; set; }
        #endregion

        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIp { get; set; }

        #region Expandable CustomerSignature

        [JsonIgnore]
        public string CustomerSignatureId
        {
            get => this.InternalCustomerSignature?.Id;
            set => this.InternalCustomerSignature = SetExpandableFieldId(value, this.InternalCustomerSignature);
        }

        [JsonIgnore]
        public File CustomerSignature
        {
            get => this.InternalCustomerSignature?.ExpandedObject;
            set => this.InternalCustomerSignature = SetExpandableFieldObject(value, this.InternalCustomerSignature);
        }

        [JsonProperty("customer_signature")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCustomerSignature { get; set; }
        #endregion

        #region Expandable DuplicateChargeDocumentation

        [JsonIgnore]
        public string DuplicateChargeDocumentationId
        {
            get => this.InternalDuplicateChargeDocumentation?.Id;
            set => this.InternalDuplicateChargeDocumentation = SetExpandableFieldId(value, this.InternalDuplicateChargeDocumentation);
        }

        [JsonIgnore]
        public File DuplicateChargeDocumentation
        {
            get => this.InternalDuplicateChargeDocumentation?.ExpandedObject;
            set => this.InternalDuplicateChargeDocumentation = SetExpandableFieldObject(value, this.InternalDuplicateChargeDocumentation);
        }

        [JsonProperty("duplicate_charge_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalDuplicateChargeDocumentation { get; set; }
        #endregion

        [JsonProperty("duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [JsonProperty("duplicate_charge_id")]
        public string DuplicateChargeId { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        #region Expandable Receipt

        [JsonIgnore]
        public string ReceiptId
        {
            get => this.InternalReceipt?.Id;
            set => this.InternalReceipt = SetExpandableFieldId(value, this.InternalReceipt);
        }

        [JsonIgnore]
        public File Receipt
        {
            get => this.InternalReceipt?.ExpandedObject;
            set => this.InternalReceipt = SetExpandableFieldObject(value, this.InternalReceipt);
        }

        [JsonProperty("receipt")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalReceipt { get; set; }
        #endregion

        #region Expandable RefundPolicy

        [JsonIgnore]
        public string RefundPolicyId
        {
            get => this.InternalRefundPolicy?.Id;
            set => this.InternalRefundPolicy = SetExpandableFieldId(value, this.InternalRefundPolicy);
        }

        [JsonIgnore]
        public File RefundPolicy
        {
            get => this.InternalRefundPolicy?.ExpandedObject;
            set => this.InternalRefundPolicy = SetExpandableFieldObject(value, this.InternalRefundPolicy);
        }

        [JsonProperty("refund_policy")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalRefundPolicy { get; set; }
        #endregion

        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        #region Expandable ServiceDocumentation

        [JsonIgnore]
        public string ServiceDocumentationId
        {
            get => this.InternalServiceDocumentation?.Id;
            set => this.InternalServiceDocumentation = SetExpandableFieldId(value, this.InternalServiceDocumentation);
        }

        [JsonIgnore]
        public File ServiceDocumentation
        {
            get => this.InternalServiceDocumentation?.ExpandedObject;
            set => this.InternalServiceDocumentation = SetExpandableFieldObject(value, this.InternalServiceDocumentation);
        }

        [JsonProperty("service_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalServiceDocumentation { get; set; }
        #endregion

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("shipping_date")]
        public string ShippingDate { get; set; }

        #region Expandable ShippingDocumentation

        [JsonIgnore]
        public string ShippingDocumentationId
        {
            get => this.InternalShippingDocumentation?.Id;
            set => this.InternalShippingDocumentation = SetExpandableFieldId(value, this.InternalShippingDocumentation);
        }

        [JsonIgnore]
        public File ShippingDocumentation
        {
            get => this.InternalShippingDocumentation?.ExpandedObject;
            set => this.InternalShippingDocumentation = SetExpandableFieldObject(value, this.InternalShippingDocumentation);
        }

        [JsonProperty("shipping_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalShippingDocumentation { get; set; }
        #endregion

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        #region Expandable UncategorizedFile

        [JsonIgnore]
        public string UncategorizedFileId
        {
            get => this.InternalUncategorizedFile?.Id;
            set => this.InternalUncategorizedFile = SetExpandableFieldId(value, this.InternalUncategorizedFile);
        }

        [JsonIgnore]
        public File UncategorizedFile
        {
            get => this.InternalUncategorizedFile?.ExpandedObject;
            set => this.InternalUncategorizedFile = SetExpandableFieldObject(value, this.InternalUncategorizedFile);
        }

        [JsonProperty("uncategorized_file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalUncategorizedFile { get; set; }
        #endregion

        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}
