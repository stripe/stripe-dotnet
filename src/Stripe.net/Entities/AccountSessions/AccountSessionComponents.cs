// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponents : StripeEntity<AccountSessionComponents>
    {
        [JsonProperty("account_management")]
        public AccountSessionComponentsAccountManagement AccountManagement { get; set; }

        [JsonProperty("account_onboarding")]
        public AccountSessionComponentsAccountOnboarding AccountOnboarding { get; set; }

        [JsonProperty("balances")]
        public AccountSessionComponentsBalances Balances { get; set; }

        [JsonProperty("documents")]
        public AccountSessionComponentsDocuments Documents { get; set; }

        [JsonProperty("notification_banner")]
        public AccountSessionComponentsNotificationBanner NotificationBanner { get; set; }

        [JsonProperty("payment_details")]
        public AccountSessionComponentsPaymentDetails PaymentDetails { get; set; }

        [JsonProperty("payments")]
        public AccountSessionComponentsPayments Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSessionComponentsPayouts Payouts { get; set; }

        [JsonProperty("payouts_list")]
        public AccountSessionComponentsPayoutsList PayoutsList { get; set; }
    }
}
