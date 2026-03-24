// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for Stripe consumer card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerAccountHolderOptions AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticOptions Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankOptions CrossRiverBank { get; set; }

        /// <summary>
        /// Terms of service acceptances for Stripe consumer card Global issuing.
        /// </summary>
        [JsonProperty("global_account_holder")]
        [STJS.JsonPropertyName("global_account_holder")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerGlobalAccountHolderOptions GlobalAccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadOptions Lead { get; set; }
    }
}
