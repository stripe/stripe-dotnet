// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances to create cards for commercial issuing use cases.
        /// </summary>
        [JsonProperty("commercial")]
        [STJS.JsonPropertyName("commercial")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions Commercial { get; set; }
    }
}
