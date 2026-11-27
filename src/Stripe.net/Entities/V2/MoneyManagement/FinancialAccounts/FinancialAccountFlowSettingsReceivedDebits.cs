// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFlowSettingsReceivedDebits : StripeEntity<FinancialAccountFlowSettingsReceivedDebits>
    {
        /// <summary>
        /// Settings for ACH received debits.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAccountFlowSettingsReceivedDebitsAch Ach { get; set; }
    }
}
