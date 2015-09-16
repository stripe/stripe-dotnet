using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDispute
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                ExpandableProperty<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("balance_transactions")]
        public List<StripeBalanceTransaction> BalanceTransactions { get; set; }

        // needs evidence object
        [JsonProperty("evidence_details")]
        public StripeDisputeEvidenceDetails EvidenceDetails { get; set; }

        // needs evidence_details
        [JsonProperty("evidence")]
        public StripeDisputeEvidence Evidence { get; set; }

        [JsonProperty("is_charge_refundable")]
        public bool IsChargeRefundable { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }

    public class StripeDisputeEvidenceDetails
    {

        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("due_by")]
        public DateTime? DueBy { get; set; }

        [JsonProperty("past_due")]
        public bool PastDue { get; set; }

        [JsonProperty("has_evidence")]
        public bool HasEvidence { get; set; }

        [JsonProperty("submission_count")]
        public int SubmissionCount { get; set; }
    }

    public class StripeDisputeEvidence
    {

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIp { get; set; }

        [JsonProperty("customer_signature")]
        public string CustomerSignature { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("shipping_date")]
        public string ShippingDate { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        [JsonProperty("shipping_documentation")]
        public string ShippingDocumentation { get; set; }

        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_documentation")]
        public string ServiceDocumentation { get; set; }

        [JsonProperty("duplicate_charge_id")]
        public string DuplicateChargeId { get; set; }

        [JsonProperty("duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [JsonProperty("refund_policy")]
        public string RefundPolicy { get; set; }

        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [JsonProperty("cancellation_policy")]
        public string CancellationPolicy { get; set; }

        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        [JsonProperty("customer_communication")]
        public string CustomerCommunication { get; set; }

        [JsonProperty("uncategorized_file")]
        public string UncategorizedFile { get; set; }

        [JsonProperty("uncategorized_text")]
        public string UncategorizedText { get; set; }


    }


}