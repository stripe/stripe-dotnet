// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsStateSalesTaxElectionOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://www.census.gov/library/reference/code-lists/ansi.html">FIPS code</a>
        /// representing the local jurisdiction. Supported FIPS codes are: <c>003</c> (Allegheny
        /// County) and <c>60000</c> (Philadelphia City).
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The type of the election for the state sales tax registration.
        /// One of: <c>local_use_tax</c>, <c>simplified_sellers_use_tax</c>, or
        /// <c>single_local_use_tax</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
