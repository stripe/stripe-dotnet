// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsSmartDisputes : StripeEntity<AccountSettingsSmartDisputes>
    {
        [JsonProperty("auto_respond")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_respond")]
#endif
        public AccountSettingsSmartDisputesAutoRespond AutoRespond { get; set; }
    }
}
