// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsPaymentDetailsFeatures : StripeEntity<AccountSessionComponentsPaymentDetailsFeatures>
    {
        /// <summary>
        /// Whether to allow capturing and cancelling payment intents. This is <c>true</c> by
        /// default.
        /// </summary>
        [JsonProperty("capture_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_payments")]
#endif
        public bool CapturePayments { get; set; }

        /// <summary>
        /// Whether connected accounts can manage destination charges that are created on behalf of
        /// them. This is <c>false</c> by default.
        /// </summary>
        [JsonProperty("destination_on_behalf_of_charge_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_on_behalf_of_charge_management")]
#endif
        public bool DestinationOnBehalfOfChargeManagement { get; set; }

        /// <summary>
        /// Whether responding to disputes is enabled, including submitting evidence and accepting
        /// disputes. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("dispute_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute_management")]
#endif
        public bool DisputeManagement { get; set; }

        /// <summary>
        /// Whether sending refunds is enabled. This is <c>true</c> by default.
        /// </summary>
        [JsonProperty("refund_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_management")]
#endif
        public bool RefundManagement { get; set; }
    }
}
