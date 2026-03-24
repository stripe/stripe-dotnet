// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemPricingLicenseFeeDetails : StripeEntity<InvoiceLineItemPricingLicenseFeeDetails>
    {
        /// <summary>
        /// The ID of the license fee this item is associated with.
        /// </summary>
        [JsonProperty("license_fee")]
        [STJS.JsonPropertyName("license_fee")]
        public string LicenseFee { get; set; }

        /// <summary>
        /// The version of the license fee this item is associated with.
        /// </summary>
        [JsonProperty("license_fee_version")]
        [STJS.JsonPropertyName("license_fee_version")]
        public string LicenseFeeVersion { get; set; }

        /// <summary>
        /// The ID of the licensed item this item is associated with.
        /// </summary>
        [JsonProperty("licensed_item")]
        [STJS.JsonPropertyName("licensed_item")]
        public string LicensedItem { get; set; }
    }
}
