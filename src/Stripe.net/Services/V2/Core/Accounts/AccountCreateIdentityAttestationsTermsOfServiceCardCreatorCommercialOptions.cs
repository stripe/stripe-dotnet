// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for Stripe commercial card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("celtic")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticOptions Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cross_river_bank")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankOptions CrossRiverBank { get; set; }
    }
}
