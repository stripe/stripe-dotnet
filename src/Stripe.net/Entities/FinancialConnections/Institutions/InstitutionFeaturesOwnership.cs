// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InstitutionFeaturesOwnership : StripeEntity<InstitutionFeaturesOwnership>
    {
        /// <summary>
        /// Whether the given feature is supported by this institution.
        /// </summary>
        [JsonProperty("supported")]
        [STJS.JsonPropertyName("supported")]
        public bool Supported { get; set; }
    }
}
