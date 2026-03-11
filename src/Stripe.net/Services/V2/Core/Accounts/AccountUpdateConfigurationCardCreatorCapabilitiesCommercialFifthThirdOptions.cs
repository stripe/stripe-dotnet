// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCardCreatorCapabilitiesCommercialFifthThirdOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Fifth Third as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialFifthThirdChargeCardOptions ChargeCard { get; set; }
    }
}
