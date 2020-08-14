namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Any server or activity logs showing proof that the customer accessed or downloaded the
        /// purchased digital product. This information should include IP addresses, corresponding
        /// timestamps, and any detailed recorded activity. Has a maximum character count of 20,000.
        /// </summary>
        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        /// <summary>
        /// The billing address provided by the customer.
        /// </summary>
        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// subscription cancellation policy, as shown to the customer.
        /// </summary>
        [JsonProperty("cancellation_policy")]
        public string CancellationPolicy { get; set; }

        /// <summary>
        /// An explanation of how and when the customer was shown your refund policy prior to
        /// purchase. Has a maximum character count of 20,000.
        /// </summary>
        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        /// <summary>
        /// A justification for why the customer's subscription was not canceled. Has a maximum
        /// character count of 20,000.
        /// </summary>
        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// communication with the customer that you feel is relevant to your case. Examples include
        /// emails proving that the customer received the product or service, or demonstrating their
        /// use of or satisfaction with the product or service.
        /// </summary>
        [JsonProperty("customer_communication")]
        public string CustomerCommunication { get; set; }

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

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A
        /// relevant document or contract showing the customer's signature.
        /// </summary>
        [JsonProperty("customer_signature")]
        public string CustomerSignature { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation for the prior charge that can uniquely identify the charge, such as a
        /// receipt, shipping label, work order, etc. This document should be paired with a similar
        /// document from the disputed payment that proves the two payments are separate.
        /// </summary>
        [JsonProperty("duplicate_charge_documentation")]
        public string DuplicateChargeDocumentation { get; set; }

        /// <summary>
        /// An explanation of the difference between the disputed charge versus the prior charge
        /// that appears to be a duplicate. Has a maximum character count of 20,000.
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
        /// A description of the product or service that was sold. Has a maximum character count of
        /// 20,000.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// receipt or message sent to the customer notifying them of the charge.
        /// </summary>
        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Your
        /// refund policy, as shown to the customer.
        /// </summary>
        [JsonProperty("refund_policy")]
        public string RefundPolicy { get; set; }

        /// <summary>
        /// Documentation demonstrating that the customer was shown your refund policy prior to
        /// purchase. Has a maximum character count of 20,000.
        /// </summary>
        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        /// <summary>
        /// A justification for why the customer is not entitled to a refund. Has a maximum
        /// character count of 20,000.
        /// </summary>
        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        /// <summary>
        /// The date on which the customer received or began receiving the purchased service, in a
        /// clear human-readable format.
        /// </summary>
        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a service was provided to the customer. This could
        /// include a copy of a signed contract, work order, or other form of written agreement.
        /// </summary>
        [JsonProperty("service_documentation")]
        public string ServiceDocumentation { get; set; }

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

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Documentation showing proof that a product was shipped to the customer at the same
        /// address the customer provided to you. This could include a copy of the shipment receipt,
        /// shipping label, etc. It should show the customer's full shipping address, if possible.
        /// </summary>
        [JsonProperty("shipping_documentation")]
        public string ShippingDocumentation { get; set; }

        /// <summary>
        /// The tracking number for a physical product, obtained from the delivery service. If
        /// multiple tracking numbers were generated for this purchase, please separate them with
        /// commas.
        /// </summary>
        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) Any
        /// additional evidence or statements.
        /// </summary>
        [JsonProperty("uncategorized_file")]
        public string UncategorizedFile { get; set; }

        /// <summary>
        /// Any additional evidence or statements. Has a maximum character count of 20,000.
        /// </summary>
        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }
    }
}
