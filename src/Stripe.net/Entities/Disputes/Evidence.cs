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
        public string CancellationPolicyId { get; set; }

        /// <summary>
        /// (Expanded) Your subscription cancellation policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public File CancellationPolicy { get; set; }

        [JsonProperty("cancellation_policy")]
        internal object InternalCancellationPolicy
        {
            get
            {
                return this.CancellationPolicy ?? (object)this.CancellationPolicyId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.CancellationPolicyId = s, o => this.CancellationPolicy = o);
            }
        }
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
        public string CustomerCommunicationId { get; set; }

        /// <summary>
        /// (Expanded) Any communication with the customer that you feel is relevant to your case.
        /// Examples include emails proving that the customer received the product or service, or
        /// demonstrating their use of or satisfaction with the product or service.
        /// </summary>
        [JsonIgnore]
        public File CustomerCommunication { get; set; }

        [JsonProperty("customer_communication")]
        internal object InternalCustomerCommunication
        {
            get
            {
                return this.CustomerCommunication ?? (object)this.CustomerCommunicationId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.CustomerCommunicationId = s, o => this.CustomerCommunication = o);
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

        /// <summary>
        /// (ID of a <see cref="File"/>) A relevant document or contract showing the customer’s
        /// signature.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CustomerSignatureId { get; set; }

        /// <summary>
        /// (Expanded) A relevant document or contract showing the customer’s signature.
        /// </summary>
        [JsonIgnore]
        public File CustomerSignature { get; set; }

        [JsonProperty("customer_signature")]
        internal object InternalCustomerSignature
        {
            get
            {
                return this.CustomerSignature ?? (object)this.CustomerSignatureId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.CustomerSignatureId = s, o => this.CustomerSignature = o);
            }
        }
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
        public string DuplicateChargeDocumentationId { get; set; }

        /// <summary>
        /// (Expanded) Documentation for the prior charge that can uniquely  identify the charge,
        /// such as a receipt, shipping label, work order, etc. This document should be paired with
        /// a similar document from the disputed payment that proves the two payments are separate.
        /// </summary>
        [JsonIgnore]
        public File DuplicateChargeDocumentation { get; set; }

        [JsonProperty("duplicate_charge_documentation")]
        internal object InternalDuplicateChargeDocumentation
        {
            get
            {
                return this.DuplicateChargeDocumentation ?? (object)this.DuplicateChargeDocumentationId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.DuplicateChargeDocumentationId = s, o => this.DuplicateChargeDocumentation = o);
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

        /// <summary>
        /// (ID of a <see cref="File"/>) Any receipt or message sent to the customer notifying them
        /// of the charge.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ReceiptId { get; set; }

        /// <summary>
        /// (Expanded) Any receipt or message sent to the customer notifying them of the charge.
        /// </summary>
        [JsonIgnore]
        public File Receipt { get; set; }

        [JsonProperty("receipt")]
        internal object InternalReceipt
        {
            get
            {
                return this.Receipt ?? (object)this.ReceiptId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.ReceiptId = s, o => this.Receipt = o);
            }
        }
        #endregion

        #region Expandable Refund Policy

        /// <summary>
        /// (ID of a <see cref="File"/>) Your refund policy, as shown to the customer.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string RefundPolicyId { get; set; }

        /// <summary>
        /// (Expanded) Your refund policy, as shown to the customer.
        /// </summary>
        [JsonIgnore]
        public File RefundPolicy { get; set; }

        [JsonProperty("refund_policy")]
        internal object InternalRefundPolicy
        {
            get
            {
                return this.RefundPolicy ?? (object)this.RefundPolicyId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.RefundPolicyId = s, o => this.RefundPolicy = o);
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

        /// <summary>
        /// (ID of a <see cref="File"/>) Documentation showing proof that a service was provided to
        /// the customer. This could include a copy of a signed contract, work order, or other form
        /// of written agreement.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ServiceDocumentationId { get; set; }

        /// <summary>
        /// (Expanded) Documentation showing proof that a service was provided to  the customer.
        /// This could include a copy of a signed contract, work order, or other form of written
        /// agreement.
        /// </summary>
        [JsonIgnore]
        public File ServiceDocumentation { get; set; }

        [JsonProperty("service_documentation")]
        internal object InternalServiceDocumentation
        {
            get
            {
                return this.ServiceDocumentation ?? (object)this.ServiceDocumentationId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.ServiceDocumentationId = s, o => this.ServiceDocumentation = o);
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

        /// <summary>
        /// (ID of a <see cref="File"/>) Documentation showing proof that a product was shipped to
        /// the customer at the same address the customer provided to you. This could include a copy
        /// of the shipment receipt, shipping label, etc. It should show the customer’s full
        /// shipping address, if possible.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string ShippingDocumentationId { get; set; }

        /// <summary>
        /// (Expanded) Documentation showing proof that a product was shipped to  the customer at
        /// the same address the customer provided to you. This could include a copy of the shipment
        /// receipt, shipping label, etc. It should show the customer’s full shipping address, if
        /// possible.
        /// </summary>
        [JsonIgnore]
        public File ShippingDocumentation { get; set; }

        [JsonProperty("shipping_documentation")]
        internal object InternalShippingDocumentation
        {
            get
            {
                return this.ShippingDocumentation ?? (object)this.ShippingDocumentationId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.ShippingDocumentationId = s, o => this.ShippingDocumentation = o);
            }
        }
        #endregion

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        #region Expandable Uncategorized File

        /// <summary>
        /// (ID of a <see cref="File"/>) Any additional evidence or statements.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string UncategorizedFileId { get; set; }

        /// <summary>
        /// (Expanded) Any additional evidence or statements.
        /// </summary>
        [JsonIgnore]
        public File UncategorizedFile { get; set; }

        [JsonProperty("uncategorized_file")]
        internal object InternalUncategorizedFile
        {
            get
            {
                return this.UncategorizedFile ?? (object)this.UncategorizedFileId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.UncategorizedFileId = s, o => this.UncategorizedFile = o);
            }
        }
        #endregion

        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}
