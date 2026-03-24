// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreator : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreator>
    {
        /// <summary>
        /// Terms of service acceptances to create cards for commercial issuing use cases.
        /// </summary>
        [JsonProperty("commercial")]
        [STJS.JsonPropertyName("commercial")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercial Commercial { get; set; }

        /// <summary>
        /// Terms of service acceptances to create cards for consumer issuing use cases.
        /// </summary>
        [JsonProperty("consumer")]
        [STJS.JsonPropertyName("consumer")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumer Consumer { get; set; }
    }
}
