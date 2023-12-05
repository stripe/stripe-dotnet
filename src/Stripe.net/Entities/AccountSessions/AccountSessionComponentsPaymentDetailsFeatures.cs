// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsPaymentDetailsFeatures : StripeEntity<AccountSessionComponentsPaymentDetailsFeatures>
    {
        /// <summary>
        /// Whether to allow capturing and cancelling payment intents. This is <c>true</c> by
        /// default.
        /// </summary>
        [JsonProperty("capture_payments")]
        public bool CapturePayments { get; set; }

        /// <summary>
        /// Whether to allow responding to disputes, including submitting evidence and accepting
        /// disputes. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("dispute_management")]
        public bool DisputeManagement { get; set; }

        /// <summary>
        /// Whether to allow sending refunds. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("refund_management")]
        public bool RefundManagement { get; set; }
    }
}
