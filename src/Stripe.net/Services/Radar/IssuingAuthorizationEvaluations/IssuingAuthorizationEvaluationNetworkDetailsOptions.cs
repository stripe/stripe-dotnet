// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The acquiring institution identifier.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acquiring_institution_id")]
#endif
        public string AcquiringInstitutionId { get; set; }

        /// <summary>
        /// The card network that routed the authorization.
        /// One of: <c>cirrus</c>, <c>interlink</c>, <c>maestro</c>, <c>mastercard</c>,
        /// <c>other</c>, <c>plus</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("routed_network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routed_network")]
#endif
        public string RoutedNetwork { get; set; }
    }
}
