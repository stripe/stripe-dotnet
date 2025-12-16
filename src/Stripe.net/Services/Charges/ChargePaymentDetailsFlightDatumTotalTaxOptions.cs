// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsFlightDatumTotalTaxOptions : INestedOptions
    {
        /// <summary>
        /// Array of tax details.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<ChargePaymentDetailsFlightDatumTotalTaxTaxOptions> Taxes { get; set; }
    }
}
