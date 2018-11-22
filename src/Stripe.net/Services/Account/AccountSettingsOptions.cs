namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsOptions : INestedOptions
    {
        [JsonProperty("charge")]
        public AccountSettingsChargeOptions Charge { get; set; }

        [JsonProperty("payout")]
        public AccountSettingsPayoutOptions Payout { get; set; }
    }
}
