namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidence : StripeEntity<DisputeEvidence>
    {
        /// <summary>
        /// Any server or activity logs showing proof that the customer accessed or downloaded the
        /// purchased digital product. This information should include IP addresses, corresponding
        /// timestamps, and any detailed recorded activity.
        /// </summary>
        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        /// <summary>
        /// The billing address provided by the customer.
        /// </summary>
        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        #region Expandable CancellationPolicy

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// subscription cancellation policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public string CancellationPolicyId
        {
            get => this.InternalCancellationPolicy?.Id;
            set => this.InternalCancellationPolicy = SetExpandableFieldId(value, this.InternalCancellationPolicy);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// subscription cancellation policy, as shown to the customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// An explanation of how and when the customer was shown your refund policy prior to
        /// purchase.
        /// </summary>
        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        /// <summary>
        /// A justification for why the customer's subscription was not canceled.
        /// </summary>
        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        #region Expandable CustomerCommunication

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// communication with the customer that you feel is relevant to your case. Examples include
        /// emails proving that the customer received the product or service, or demonstrating their
        /// use of or satisfaction with the product or service.
        /// </summary>
        [JsonIgnore]
        public string CustomerCommunicationId
        {
            get => this.InternalCustomerCommunication?.Id;
            set => this.InternalCustomerCommunication = SetExpandableFieldId(value, this.InternalCustomerCommunication);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// communication with the customer that you feel is relevant to your case. Examples include
        /// emails proving that the customer received the product or service, or demonstrating their
        /// use of or satisfaction with the product or service.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The name of the customer.
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// The IP address that the customer used when making the purchase.
        /// </summary>
        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIp { get; set; }

        #region Expandable CustomerSignature

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A
        /// relevant document or contract showing the customer's signature.
        /// </summary>
        [JsonIgnore]
        public string CustomerSignatureId
        {
            get => this.InternalCustomerSignature?.Id;
            set => this.InternalCustomerSignature = SetExpandableFieldId(value, this.InternalCustomerSignature);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A
        /// relevant document or contract showing the customer's signature.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation for the prior charge that can uniquely identify the charge, such as a
        /// receipt, shipping label, work order, etc. This document should be paired with a similar
        /// document from the disputed payment that proves the two payments are separate.
        /// </summary>
        [JsonIgnore]
        public string DuplicateChargeDocumentationId
        {
            get => this.InternalDuplicateChargeDocumentation?.Id;
            set => this.InternalDuplicateChargeDocumentation = SetExpandableFieldId(value, this.InternalDuplicateChargeDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation for the prior charge that can uniquely identify the charge, such as a
        /// receipt, shipping label, work order, etc. This document should be paired with a similar
        /// document from the disputed payment that proves the two payments are separate.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// An explanation of the difference between the disputed charge versus the prior charge
        /// that appears to be a duplicate.
        /// </summary>
        [JsonProperty("duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        /// <summary>
        /// The Stripe ID for the prior charge which appears to be a duplicate of the disputed
        /// charge.
        /// </summary>
        [JsonProperty("duplicate_charge_id")]
        public string DuplicateChargeId { get; set; }

        /// <summary>
        /// A description of the product or service that was sold.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        #region Expandable Receipt

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// receipt or message sent to the customer notifying them of the charge.
        /// </summary>
        [JsonIgnore]
        public string ReceiptId
        {
            get => this.InternalReceipt?.Id;
            set => this.InternalReceipt = SetExpandableFieldId(value, this.InternalReceipt);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// receipt or message sent to the customer notifying them of the charge.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// refund policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public string RefundPolicyId
        {
            get => this.InternalRefundPolicy?.Id;
            set => this.InternalRefundPolicy = SetExpandableFieldId(value, this.InternalRefundPolicy);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// refund policy, as shown to the customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// Documentation demonstrating that the customer was shown your refund policy prior to
        /// purchase.
        /// </summary>
        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        /// <summary>
        /// A justification for why the customer is not entitled to a refund.
        /// </summary>
        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        /// <summary>
        /// The date on which the customer received or began receiving the purchased service, in a
        /// clear human-readable format.
        /// </summary>
        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        #region Expandable ServiceDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a service was provided to the customer. This could
        /// include a copy of a signed contract, work order, or other form of written agreement.
        /// </summary>
        [JsonIgnore]
        public string ServiceDocumentationId
        {
            get => this.InternalServiceDocumentation?.Id;
            set => this.InternalServiceDocumentation = SetExpandableFieldId(value, this.InternalServiceDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a service was provided to the customer. This could
        /// include a copy of a signed contract, work order, or other form of written agreement.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// The address to which a physical product was shipped. You should try to include as
        /// complete address information as possible.
        /// </summary>
        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc. If
        /// multiple carriers were used for this purchase, please separate them with commas.
        /// </summary>
        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        /// <summary>
        /// The date on which a physical product began its route to the shipping address, in a clear
        /// human-readable format.
        /// </summary>
        [JsonProperty("shipping_date")]
        public string ShippingDate { get; set; }

        #region Expandable ShippingDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a product was shipped to the customer at the same
        /// address the customer provided to you. This could include a copy of the shipment receipt,
        /// shipping label, etc. It should show the customer's full shipping address, if possible.
        /// </summary>
        [JsonIgnore]
        public string ShippingDocumentationId
        {
            get => this.InternalShippingDocumentation?.Id;
            set => this.InternalShippingDocumentation = SetExpandableFieldId(value, this.InternalShippingDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a product was shipped to the customer at the same
        /// address the customer provided to you. This could include a copy of the shipment receipt,
        /// shipping label, etc. It should show the customer's full shipping address, if possible.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// The tracking number for a physical product, obtained from the delivery service. If
        /// multiple tracking numbers were generated for this purchase, please separate them with
        /// commas.
        /// </summary>
        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        #region Expandable UncategorizedFile

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// additional evidence or statements.
        /// </summary>
        [JsonIgnore]
        public string UncategorizedFileId
        {
            get => this.InternalUncategorizedFile?.Id;
            set => this.InternalUncategorizedFile = SetExpandableFieldId(value, this.InternalUncategorizedFile);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// additional evidence or statements.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// Any additional evidence or statements.
        /// </summary>
        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}
