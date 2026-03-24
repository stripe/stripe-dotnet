// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormFilingStatusJurisdiction : StripeEntity<FormFilingStatusJurisdiction>
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Indicates the level of the jurisdiction where the form was filed.
        /// One of: <c>country</c>, or <c>state</c>.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US">ISO 3166-2 U.S. state code</a>,
        /// without country prefix, if any. For example, "NY" for New York, United States. Null for
        /// non-U.S. forms.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
