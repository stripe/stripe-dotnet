// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormFilingStatusJurisdiction : StripeEntity<FormFilingStatusJurisdiction>
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>). Always <c>US</c>.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Indicates the level of the jurisdiction where the form was filed.
        /// One of: <c>country</c>, or <c>state</c>.
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US">ISO 3166-2 U.S. state code</a>,
        /// without country prefix, if any. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
