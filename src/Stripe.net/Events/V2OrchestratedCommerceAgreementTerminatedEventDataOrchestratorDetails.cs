// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2OrchestratedCommerceAgreementTerminatedEventDataOrchestratorDetails : StripeEntity<V2OrchestratedCommerceAgreementTerminatedEventDataOrchestratorDetails>
    {
        /// <summary>
        /// The name of the orchestrator. This can be the name of the agent or the name of the
        /// business.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Network ID of the orchestrator.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
