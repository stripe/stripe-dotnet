// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsTreasury : StripeEntity<AccountSettingsTreasury>
    {
        [JsonProperty("tos_acceptance")]
        [STJS.JsonPropertyName("tos_acceptance")]
        public AccountSettingsTreasuryTosAcceptance TosAcceptance { get; set; }
    }
}
