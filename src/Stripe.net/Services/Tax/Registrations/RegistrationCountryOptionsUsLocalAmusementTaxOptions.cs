// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsLocalAmusementTaxOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://www.census.gov/library/reference/code-lists/ansi.html">FIPS code</a>
        /// representing the local jurisdiction. Supported FIPS codes are: <c>14000</c> (Chicago),
        /// <c>06613</c> (Bloomington), <c>21696</c> (East Dundee), <c>24582</c> (Evanston), and
        /// <c>68081</c> (Schiller Park).
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}
