namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBacsDebitPayments : StripeEntity<AccountSettingsBacsDebitPayments>
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
