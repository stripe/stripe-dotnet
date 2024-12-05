// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesInboundTransfers : StripeEntity<FinancialAccountFeaturesInboundTransfers>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling an ACH specific feature.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountFeaturesInboundTransfersAch Ach { get; set; }
    }
}
