// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationStorerCapabilitiesHoldsCurrenciesEurOptions : INestedOptions
    {
        /// <summary>
        /// To request a new Capability for an account, pass true. There can be a delay before the
        /// requested Capability becomes active.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
