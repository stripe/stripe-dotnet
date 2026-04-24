// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AgreementCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Network ID of the orchestrator to create an agreement with.
        /// </summary>
        [JsonProperty("orchestrator")]
        [STJS.JsonPropertyName("orchestrator")]
        public string Orchestrator { get; set; }
    }
}
