// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemPricingLicenseFeeDetails : StripeEntity<InvoiceItemPricingLicenseFeeDetails>
    {
        /// <summary>
        /// The ID of the license fee this item is associated with.
        /// </summary>
        [JsonProperty("license_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee")]
#endif
        public string LicenseFee { get; set; }

        /// <summary>
        /// The version of the license fee this item is associated with.
        /// </summary>
        [JsonProperty("license_fee_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_version")]
#endif
        public string LicenseFeeVersion { get; set; }

        /// <summary>
        /// The ID of the licensed item this item is associated with.
        /// </summary>
        [JsonProperty("licensed_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("licensed_item")]
#endif
        public string LicensedItem { get; set; }
    }
}
