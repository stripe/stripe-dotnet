// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesInboundFundings : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesInboundFundings>
    {
        /// <summary>
        /// Can fund a FinancialAccount by paper check.
        /// </summary>
        [JsonProperty("paper_checks")]
        [STJS.JsonPropertyName("paper_checks")]
        public AccountConfigurationMoneyManagerCapabilitiesInboundFundingsPaperChecks PaperChecks { get; set; }
    }
}
