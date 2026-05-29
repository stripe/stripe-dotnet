// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateLicenseQuantityActionOptions : INestedOptions
    {
        /// <summary>
        /// The effective at for the license quantity action.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public ContractCreateLicenseQuantityActionEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// The ID of the license pricing.
        /// </summary>
        [JsonProperty("license_pricing_id")]
        [STJS.JsonPropertyName("license_pricing_id")]
        public string LicensePricingId { get; set; }

        /// <summary>
        /// The lookup key for the license pricing.
        /// </summary>
        [JsonProperty("license_pricing_lookup_key")]
        [STJS.JsonPropertyName("license_pricing_lookup_key")]
        public string LicensePricingLookupKey { get; set; }

        /// <summary>
        /// The type of the license pricing.
        /// One of: <c>license_fee</c>, or <c>price</c>.
        /// </summary>
        [JsonProperty("license_pricing_type")]
        [STJS.JsonPropertyName("license_pricing_type")]
        public string LicensePricingType { get; set; }

        /// <summary>
        /// The pricing line for the license quantity action.
        /// </summary>
        [JsonProperty("pricing_line")]
        [STJS.JsonPropertyName("pricing_line")]
        public string PricingLine { get; set; }

        /// <summary>
        /// The set quantity for the license quantity action.
        /// </summary>
        [JsonProperty("set")]
        [STJS.JsonPropertyName("set")]
        public ContractCreateLicenseQuantityActionSetOptions Set { get; set; }

        /// <summary>
        /// The type of the license quantity action.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
