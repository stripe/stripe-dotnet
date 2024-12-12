// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InstitutionFeaturesPaymentMethod : StripeEntity<InstitutionFeaturesPaymentMethod>
    {
        /// <summary>
        /// Whether the given feature is supported by this institution.
        /// </summary>
        [JsonProperty("supported")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported")]
#endif
        public bool Supported { get; set; }
    }
}
