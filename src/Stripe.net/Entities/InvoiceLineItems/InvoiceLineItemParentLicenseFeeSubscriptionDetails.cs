// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemParentLicenseFeeSubscriptionDetails : StripeEntity<InvoiceLineItemParentLicenseFeeSubscriptionDetails>
    {
        /// <summary>
        /// The invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item")]
#endif
        public string InvoiceItem { get; set; }

        /// <summary>
        /// The license fee subscription that generated this line item.
        /// </summary>
        [JsonProperty("license_fee_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_subscription")]
#endif
        public string LicenseFeeSubscription { get; set; }

        /// <summary>
        /// The license fee version at the time this line item was generated.
        /// </summary>
        [JsonProperty("license_fee_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_version")]
#endif
        public string LicenseFeeVersion { get; set; }

        /// <summary>
        /// The pricing plan subscription that manages the license fee subscription.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }

        /// <summary>
        /// The pricing plan version at the time this line item was generated.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }
    }
}
