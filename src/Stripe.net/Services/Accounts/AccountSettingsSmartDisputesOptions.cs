// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsSmartDisputesOptions : INestedOptions
    {
        /// <summary>
        /// Smart Disputes auto-respond settings for the account.
        /// </summary>
        [JsonProperty("auto_respond")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_respond")]
#endif
        public AccountSettingsSmartDisputesAutoRespondOptions AutoRespond { get; set; }
    }
}
