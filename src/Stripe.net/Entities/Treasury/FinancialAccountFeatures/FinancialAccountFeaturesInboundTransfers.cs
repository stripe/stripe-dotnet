// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFeaturesInboundTransfers : StripeEntity<FinancialAccountFeaturesInboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an inbound ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAccountFeaturesInboundTransfersAch Ach { get; set; }
    }
}
