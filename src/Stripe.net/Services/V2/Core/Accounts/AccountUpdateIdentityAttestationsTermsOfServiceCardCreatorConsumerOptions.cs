// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for Stripe consumer card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("celtic")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticOptions Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cross_river_bank")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankOptions CrossRiverBank { get; set; }

        /// <summary>
        /// Terms of service acceptances for Stripe consumer card Global issuing.
        /// </summary>
        [JsonProperty("global_account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("global_account_holder")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerGlobalAccountHolderOptions GlobalAccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lead")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadOptions Lead { get; set; }
    }
}
