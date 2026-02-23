// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantSmartDisputes : StripeEntity<AccountConfigurationMerchantSmartDisputes>
    {
        /// <summary>
        /// Settings for Smart Disputes auto_respond.
        /// </summary>
        [JsonProperty("auto_respond")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_respond")]
#endif
        public AccountConfigurationMerchantSmartDisputesAutoRespond AutoRespond { get; set; }
    }
}
