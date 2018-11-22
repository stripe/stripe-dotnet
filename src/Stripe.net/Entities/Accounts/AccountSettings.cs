namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettings : StripeEntity
    {
        [JsonProperty("charge")]
        public AccountSettingsCharge Charge { get; set; }

        [JsonProperty("payout")]
        public AccountSettingsPayout Payout { get; set; }
    }
}
