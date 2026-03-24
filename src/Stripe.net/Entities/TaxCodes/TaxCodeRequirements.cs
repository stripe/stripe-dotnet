// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxCodeRequirements : StripeEntity<TaxCodeRequirements>
    {
        /// <summary>
        /// Describes whether a performance location is required for a successful tax calculation
        /// with a tax code.
        /// One of: <c>optional</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("performance_location")]
        [STJS.JsonPropertyName("performance_location")]
        public string PerformanceLocation { get; set; }
    }
}
