namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class DisputeUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("evidence[access_activity_log]")]
        public string AccessActivityLog { get; set; }

        [FormProperty("evidence[billing_address")]
        public string BillingAddress { get; set; }

        [FormProperty("evidence[cancellation_policy")]
        public string CancellationPolicyFileId { get; set; }

        [FormProperty("evidence[cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [FormProperty("evidence[cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        [FormProperty("evidence[customer_communication")]
        public string CustomerCommunicationFileId { get; set; }

        [FormProperty("evidence[customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [FormProperty("evidence[customer_name")]
        public string CustomerName { get; set; }

        [FormProperty("evidence[customer_purchase_ip")]
        public string CustomerPurchaseIPAddress { get; set; }

        [FormProperty("evidence[customer_signature")]
        public string CustomerSignatureFileId { get; set; }

        [FormProperty("evidence[duplicate_charge_documentation")]
        public string DuplicateChargeDocumentation { get; set; }

        [FormProperty("evidence[duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [FormProperty("evidence[duplicate_charge_id")]
        public string DuplicateChargeFileId { get; set; }

        [FormProperty("evidence[product_description")]
        public string ProductDescription { get; set; }

        [FormProperty("evidence[receipt")]
        public string ReceiptFileId { get; set; }

        [FormProperty("evidence[refund_policy")]
        public string RefundPolicyFileId { get; set; }

        [FormProperty("evidence[refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [FormProperty("evidence[refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [FormProperty("evidence[service_date")]
        public string ServiceDate { get; set; }

        [FormProperty("evidence[service_documentation")]
        public string ServiceDocumentationFileId { get; set; }

        [FormProperty("evidence[shipping_address")]
        public string ShippingAddress { get; set; }

        [FormProperty("evidence[shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [FormProperty("evidence[shipping_date")]
        public string ShippingDate { get; set; }

        [FormProperty("evidence[shipping_documentation")]
        public string ShippingDocumentation { get; set; }

        [FormProperty("evidence[shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        [FormProperty("evidence[uncategorized_file")]
        public string UncategorizedFileId { get; set; }

        [FormProperty("evidence[uncategorized_text")]
        public string UncategorizedText { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
