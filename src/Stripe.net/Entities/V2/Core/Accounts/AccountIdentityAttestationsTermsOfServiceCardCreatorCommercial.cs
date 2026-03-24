// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercial : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercial>
    {
        /// <summary>
        /// Terms of service acceptances for Stripe commercial card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCeltic Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBank CrossRiverBank { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Fifth Third as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("fifth_third")]
        [STJS.JsonPropertyName("fifth_third")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThird FifthThird { get; set; }

        /// <summary>
        /// Terms of service acceptances for Stripe commercial card Global issuing.
        /// </summary>
        [JsonProperty("global_account_holder")]
        [STJS.JsonPropertyName("global_account_holder")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialGlobalAccountHolder GlobalAccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLead Lead { get; set; }
    }
}
