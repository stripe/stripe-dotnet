// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUsLocalAmusementTaxOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://www.census.gov/library/reference/code-lists/ansi.html">FIPS code</a>
        /// representing the local jurisdiction. Supported FIPS codes are: <c>14000</c> (Chicago),
        /// <c>06613</c> (Bloomington), <c>21696</c> (East Dundee), <c>24582</c> (Evanston),
        /// <c>45421</c> (Lynwood), <c>48892</c> (Midlothian), <c>64343</c> (River Grove), and
        /// <c>68081</c> (Schiller Park).
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }
    }
}
