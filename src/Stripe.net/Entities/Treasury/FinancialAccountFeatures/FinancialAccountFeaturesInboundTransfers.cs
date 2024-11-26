// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesInboundTransfers : StripeEntity<FinancialAccountFeaturesInboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public FinancialAccountFeaturesInboundTransfersAch Ach { get; set; }
    }
}
