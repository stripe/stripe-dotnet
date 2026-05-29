// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractLicenseQuantity : StripeEntity<ContractLicenseQuantity>
    {
        /// <summary>
        /// The ID of the license pricing.
        /// </summary>
        [JsonProperty("license_pricing_id")]
        [STJS.JsonPropertyName("license_pricing_id")]
        public string LicensePricingId { get; set; }

        /// <summary>
        /// The type of the license pricing.
        /// One of: <c>license_fee</c>, or <c>price</c>.
        /// </summary>
        [JsonProperty("license_pricing_type")]
        [STJS.JsonPropertyName("license_pricing_type")]
        public string LicensePricingType { get; set; }

        /// <summary>
        /// The ID of the pricing line associated with this license quantity.
        /// </summary>
        [JsonProperty("pricing_line")]
        [STJS.JsonPropertyName("pricing_line")]
        public string PricingLine { get; set; }

        /// <summary>
        /// The current quantity of the license.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
