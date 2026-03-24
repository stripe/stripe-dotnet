// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsOwnershipDeclarationOptions : INestedOptions
    {
        /// <summary>
        /// A boolean indicating if the beneficial owner information has been attested.
        /// </summary>
        [JsonProperty("attested")]
        [STJS.JsonPropertyName("attested")]
        public bool? Attested { get; set; }
    }
}
