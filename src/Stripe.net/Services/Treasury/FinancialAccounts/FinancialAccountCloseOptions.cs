// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// A different bank account where funds can be deposited/debited in order to get the
        /// closing FA's balance to $0.
        /// </summary>
        [JsonProperty("forwarding_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("forwarding_settings")]
#endif
        public FinancialAccountForwardingSettingsOptions ForwardingSettings { get; set; }
    }
}
