// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuingAuthorizationEvaluationNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network. Sometimes this value is not
        /// provided by the network; in this case, the value will be null.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        [STJS.JsonPropertyName("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }

        /// <summary>
        /// The card network over which Stripe received the authorization.
        /// One of: <c>cirrus</c>, <c>interlink</c>, <c>maestro</c>, <c>mastercard</c>,
        /// <c>other</c>, <c>plus</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("routed_network")]
        [STJS.JsonPropertyName("routed_network")]
        public string RoutedNetwork { get; set; }
    }
}
