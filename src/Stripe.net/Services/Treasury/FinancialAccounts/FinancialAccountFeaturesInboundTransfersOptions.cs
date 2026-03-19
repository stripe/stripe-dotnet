// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountFeaturesInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH Debits via the InboundTransfers API.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAccountFeaturesInboundTransfersAchOptions Ach { get; set; }
    }
}
