// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3PriorUndisputedTransactionShippingAddress : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3PriorUndisputedTransactionShippingAddress>
    {
        /// <summary>
        /// City, district, suburb, town, or village.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Address line 1 (e.g., street, PO Box, or company name).
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2 (e.g., apartment, suite, unit, or building).
        /// </summary>
        [JsonProperty("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State, county, province, or region.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
