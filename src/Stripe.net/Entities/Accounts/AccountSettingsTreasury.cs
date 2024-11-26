// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsTreasury : StripeEntity<AccountSettingsTreasury>
    {
        [JsonProperty("tos_acceptance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tos_acceptance")]
#endif
        public AccountSettingsTreasuryTosAcceptance TosAcceptance { get; set; }
    }
}
