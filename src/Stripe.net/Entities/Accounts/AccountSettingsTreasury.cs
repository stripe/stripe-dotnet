// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsTreasury : StripeEntity<AccountSettingsTreasury>
    {
        [JsonProperty("tos_acceptance")]
        public AccountSettingsTreasuryTosAcceptance TosAcceptance { get; set; }
    }
}
