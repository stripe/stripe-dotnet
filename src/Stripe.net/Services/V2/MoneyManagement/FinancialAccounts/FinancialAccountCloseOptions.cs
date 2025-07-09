// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// The addresses to forward any incoming transactions to.
        /// </summary>
        [JsonProperty("forwarding_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("forwarding_settings")]
#endif
        public FinancialAccountCloseForwardingSettingsOptions ForwardingSettings { get; set; }
    }
}
