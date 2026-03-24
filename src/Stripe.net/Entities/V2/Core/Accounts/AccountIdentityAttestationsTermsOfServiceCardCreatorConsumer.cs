// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorConsumer : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorConsumer>
    {
        /// <summary>
        /// Terms of service acceptances for Stripe commercial card issuing.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCeltic Celtic { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing cards with Cross River Bank as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBank CrossRiverBank { get; set; }

        /// <summary>
        /// Terms of service acceptances for Stripe commercial card Global issuing.
        /// </summary>
        [JsonProperty("global_account_holder")]
        [STJS.JsonPropertyName("global_account_holder")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerGlobalAccountHolder GlobalAccountHolder { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLead Lead { get; set; }
    }
}
