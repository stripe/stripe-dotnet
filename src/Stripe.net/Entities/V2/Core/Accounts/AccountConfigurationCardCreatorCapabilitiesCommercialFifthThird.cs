// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilitiesCommercialFifthThird : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialFifthThird>
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Fifth Third Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialFifthThirdChargeCard ChargeCard { get; set; }
    }
}
