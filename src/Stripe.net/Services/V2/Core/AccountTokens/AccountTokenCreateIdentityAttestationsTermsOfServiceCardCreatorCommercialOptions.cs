// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for Stripe commercial card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticOptions Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankOptions CrossRiverBank { get; set; }
    }
}
