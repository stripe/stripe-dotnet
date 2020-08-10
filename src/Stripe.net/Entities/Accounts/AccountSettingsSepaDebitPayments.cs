namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsSepaDebitPayments : StripeEntity<AccountSettingsSepaDebitPayments>
    {
        [JsonProperty("creditor_id")]
        public string CreditorId { get; set; }
    }
}
