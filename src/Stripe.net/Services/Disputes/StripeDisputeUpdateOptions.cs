using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDisputeUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("evidence[access_activity_log]")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("evidence[billing_address")]
        public string BillingAddress { get; set; }

        [JsonProperty("evidence[cancellation_policy")]
        public string CancellationPolicyFileId { get; set; }

        [JsonProperty("evidence[cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("evidence[cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        [JsonProperty("evidence[customer_communication")]
        public string CustomerCommunicationFileId { get; set; }

        [JsonProperty("evidence[customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("evidence[customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("evidence[customer_purchase_ip")]
        public string CustomerPurchaseIPAddress { get; set; }

        [JsonProperty("evidence[customer_signature")]
        public string CustomerSignatureFileId { get; set; }

        [JsonProperty("evidence[duplicate_charge_documentation")]
        public string DuplicateChargeDocumentation { get; set; }

        [JsonProperty("evidence[duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [JsonProperty("evidence[duplicate_charge_id")]
        public string DuplicateChargeFileId { get; set; }

        [JsonProperty("evidence[product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("evidence[receipt")]
        public string ReceiptFileId { get; set; }

        [JsonProperty("evidence[refund_policy")]
        public string RefundPolicyFileId { get; set; }

        [JsonProperty("evidence[refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [JsonProperty("evidence[refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [JsonProperty("evidence[service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("evidence[service_documentation")]
        public string ServiceDocumentationFileId { get; set; }

        [JsonProperty("evidence[shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("evidence[shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("evidence[shipping_date")]
        public string ShippingDate { get; set; }

        [JsonProperty("evidence[shipping_documentation")]
        public string ShippingDocumentation { get; set; }

        [JsonProperty("evidence[shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        [JsonProperty("evidence[uncategorized_file")]
        public string UncategorizedFileId { get; set; }

        [JsonProperty("evidence[uncategorized_text")]
        public string UncategorizedText { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
