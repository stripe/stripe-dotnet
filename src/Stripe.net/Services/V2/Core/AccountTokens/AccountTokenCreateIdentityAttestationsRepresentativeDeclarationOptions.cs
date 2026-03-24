// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsRepresentativeDeclarationOptions : INestedOptions
    {
        /// <summary>
        /// A boolean indicating if the representative is authorized to act as the representative of
        /// their legal entity.
        /// </summary>
        [JsonProperty("attested")]
        [STJS.JsonPropertyName("attested")]
        public bool? Attested { get; set; }
    }
}
