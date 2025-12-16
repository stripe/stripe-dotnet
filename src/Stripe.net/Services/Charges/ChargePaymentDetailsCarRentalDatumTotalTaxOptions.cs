// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsCarRentalDatumTotalTaxOptions : INestedOptions
    {
        /// <summary>
        /// Indicates if the transaction is tax exempt.
        /// </summary>
        [JsonProperty("tax_exempt_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_exempt_indicator")]
#endif
        public bool? TaxExemptIndicator { get; set; }

        /// <summary>
        /// Array of tax details.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<ChargePaymentDetailsCarRentalDatumTotalTaxTaxOptions> Taxes { get; set; }
    }
}
