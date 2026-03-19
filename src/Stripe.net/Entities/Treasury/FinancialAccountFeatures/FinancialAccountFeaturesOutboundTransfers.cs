// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFeaturesOutboundTransfers : StripeEntity<FinancialAccountFeaturesOutboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an outbound ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundTransfersAch Ach { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        [STJS.JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundTransfersUsDomesticWire UsDomesticWire { get; set; }
    }
}
