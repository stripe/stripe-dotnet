// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsAlternativeOriginalEntry : StripeEntity<AccountFutureRequirementsAlternativeOriginalEntry>
    {
        /// <summary>
        /// Machine-readable string describing the requirement.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A reference to the location of the requirement.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public AccountFutureRequirementsAlternativeOriginalEntryReference Reference { get; set; }
    }
}
