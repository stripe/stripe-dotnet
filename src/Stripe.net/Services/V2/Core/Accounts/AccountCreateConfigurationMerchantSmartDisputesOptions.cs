// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantSmartDisputesOptions : INestedOptions
    {
        /// <summary>
        /// Settings for Smart Disputes auto_respond.
        /// </summary>
        [JsonProperty("auto_respond")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_respond")]
#endif
        public AccountCreateConfigurationMerchantSmartDisputesAutoRespondOptions AutoRespond { get; set; }
    }
}
