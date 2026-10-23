// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// Settings that specify where to send positive balances and how to cover negative
        /// balances. You must provide these settings if the FinancialAccount has a non-zero
        /// balance.
        /// </summary>
        [JsonProperty("forwarding_settings")]
        [STJS.JsonPropertyName("forwarding_settings")]
        public FinancialAccountCloseForwardingSettingsOptions ForwardingSettings { get; set; }
    }
}
