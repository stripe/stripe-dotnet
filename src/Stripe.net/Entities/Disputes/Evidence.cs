namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Evidence : StripeEntity<Evidence>
    {
        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        #region Expandable Cancellation Policy

        /// <summary>
        /// (ID of a <see cref="File"/>) Your subscription cancellation policy, as shown to the
        /// customer.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CancellationPolicyId => this.InternalCancellationPolicy.Id;

        /// <summary>
        /// (Expanded) Your subscription cancellation policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public File CancellationPolicy => this.InternalCancellationPolicy.ExpandedObject;

        [JsonProperty("cancellation_policy")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCancellationPolicy { get; set; }
        #endregion

        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        #region Expandable Customer Communication

        /// <summary>
        /// (ID of a <see cref="File"/>) Any communication with the customer that you feel is
        /// relevant to your case. Examples include emails proving that the customer received the
        /// product or service, or demonstrating their use of or satisfaction with the product or
        /// service.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CustomerCommunicationId => this.InternalCustomerCommunication.Id;

        /// <summary>
        /// (Expanded) Any communication with the customer that you feel is relevant to your case.
        /// Examples include emails proving that the customer received the product or service, or
        /// demonstrating their use of or satisfaction with the product or service.
        /// </summary>
        [JsonIgnore]
        public File CustomerCommunication => this.InternalCustomerCommunication.ExpandedObject;

        [JsonProperty("customer_communication")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCustomerCommunication { get; set; }
        #endregion

        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIPAddress { get; set; }

        #region Expandable Customer Signature

        /// <summary>
        /// (ID of a <see cref="File"/>) A relevant document or contract showing the customer’s
        /// signature.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CustomerSignatureId => this.InternalCustomerSignature.Id;

        /// <summary>
        /// (Expanded) A relevant document or contract showing the customer’s signature.
        /// </summary>
        [JsonIgnore]
        public File CustomerSignature => this.InternalCustomerSignature.ExpandedObject;

        [JsonProperty("customer_signature")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalCustomerSignature { get; set; }
        #endregion

        #region Expandable Duplicate Charge Documentation

        /// <summary>
        /// (ID of a <see cref="File"/>) Documentation for the prior charge that can uniquely
        /// identify the charge, such as a receipt, shipping label, work order, etc. This document
        /// should be paired with a similar document from the disputed payment that proves the two
        /// payments are separate.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string DuplicateChargeDocumentationId => this.InternalDuplicateChargeDocumentation.Id;

        /// <summary>
        /// (Expanded) Documentation for the prior charge that can uniquely  identify the charge,
        /// such as a receipt, shipping label, work order, etc. This document should be paired with
        /// a similar document from the disputed payment that proves the two payments are separate.
        /// </summary>
        [JsonIgnore]
        public File DuplicateChargeDocumentation => this.InternalDuplicateChargeDocumentation.ExpandedObject;

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

        /// <summary>
        /// (ID of a <see cref="File"/>) Any receipt or message sent to the customer notifying them
        /// of the charge.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ReceiptId => this.InternalReceipt.Id;

        /// <summary>
        /// (Expanded) Any receipt or message sent to the customer notifying them of the charge.
        /// </summary>
        [JsonIgnore]
        public File Receipt => this.InternalReceipt.ExpandedObject;

        [JsonProperty("receipt")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalReceipt { get; set; }
        #endregion

        #region Expandable Refund Policy

        /// <summary>
        /// (ID of a <see cref="File"/>) Your refund policy, as shown to the customer.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string RefundPolicyId => this.InternalRefundPolicy.Id;

        /// <summary>
        /// (Expanded) Your refund policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public File RefundPolicy => this.InternalRefundPolicy.ExpandedObject;

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

        #region Expandable Service Documentation

        /// <summary>
        /// (ID of a <see cref="File"/>) Documentation showing proof that a service was provided to
        /// the customer. This could include a copy of a signed contract, work order, or other form
        /// of written agreement.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ServiceDocumentationId => this.InternalServiceDocumentation.Id;

        /// <summary>
        /// (Expanded) Documentation showing proof that a service was provided to  the customer.
        /// This could include a copy of a signed contract, work order, or other form of written
        /// agreement.
        /// </summary>
        [JsonIgnore]
        public File ServiceDocumentation => this.InternalServiceDocumentation.ExpandedObject;

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

        #region Expandable Shipping Documentation

        /// <summary>
        /// (ID of a <see cref="File"/>) Documentation showing proof that a product was shipped to
        /// the customer at the same address the customer provided to you. This could include a copy
        /// of the shipment receipt, shipping label, etc. It should show the customer’s full
        /// shipping address, if possible.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ShippingDocumentationId => this.InternalShippingDocumentation.Id;

        /// <summary>
        /// (Expanded) Documentation showing proof that a product was shipped to  the customer at
        /// the same address the customer provided to you. This could include a copy of the shipment
        /// receipt, shipping label, etc. It should show the customer’s full shipping address, if
        /// possible.
        /// </summary>
        [JsonIgnore]
        public File ShippingDocumentation => this.InternalShippingDocumentation.ExpandedObject;

        [JsonProperty("shipping_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalShippingDocumentation { get; set; }
        #endregion

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        #region Expandable Uncategorized File

        /// <summary>
        /// (ID of a <see cref="File"/>) Any additional evidence or statements.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string UncategorizedFileId => this.InternalUncategorizedFile.Id;

        /// <summary>
        /// (Expanded) Any additional evidence or statements.
        /// </summary>
        [JsonIgnore]
        public File UncategorizedFile => this.InternalUncategorizedFile.ExpandedObject;

        [JsonProperty("uncategorized_file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalUncategorizedFile { get; set; }
        #endregion

        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}
