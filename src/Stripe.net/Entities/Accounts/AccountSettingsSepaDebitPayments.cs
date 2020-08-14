namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsSepaDebitPayments : StripeEntity<AccountSettingsSepaDebitPayments>
    {
        /// <summary>
        /// SEPA creditor identifier that identifies the company making the payment.
        /// </summary>
        [JsonProperty("creditor_id")]
        public string CreditorId { get; set; }
    }
}
