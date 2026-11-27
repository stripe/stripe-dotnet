// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountUpdateFlowSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Settings for received debit flows.
        /// </summary>
        [JsonProperty("received_debits")]
        [STJS.JsonPropertyName("received_debits")]
        public FinancialAccountUpdateFlowSettingsReceivedDebitsOptions ReceivedDebits { get; set; }
    }
}
