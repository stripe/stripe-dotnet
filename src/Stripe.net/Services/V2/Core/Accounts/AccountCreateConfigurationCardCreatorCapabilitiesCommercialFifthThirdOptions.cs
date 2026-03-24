// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCardCreatorCapabilitiesCommercialFifthThirdOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Fifth Third as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialFifthThirdChargeCardOptions ChargeCard { get; set; }
    }
}
