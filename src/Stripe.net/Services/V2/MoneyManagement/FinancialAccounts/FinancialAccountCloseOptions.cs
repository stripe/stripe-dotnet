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
        /// The addresses to forward any incoming transactions to.
        /// </summary>
        [JsonProperty("forwarding_settings")]
        [STJS.JsonPropertyName("forwarding_settings")]
        public FinancialAccountCloseForwardingSettingsOptions ForwardingSettings { get; set; }
    }
}
