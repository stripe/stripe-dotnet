// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AgreementListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter list to Orchestrated Commerce Agreements with a specific counterparty.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
