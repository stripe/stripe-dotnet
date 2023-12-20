// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponents : StripeEntity<AccountSessionComponents>
    {
        [JsonProperty("account_onboarding")]
        public AccountSessionComponentsAccountOnboarding AccountOnboarding { get; set; }

        [JsonProperty("capital_financing_promotion")]
        public AccountSessionComponentsCapitalFinancingPromotion CapitalFinancingPromotion { get; set; }

        [JsonProperty("payment_details")]
        public AccountSessionComponentsPaymentDetails PaymentDetails { get; set; }

        [JsonProperty("payments")]
        public AccountSessionComponentsPayments Payments { get; set; }

        [JsonProperty("payouts")]
        public AccountSessionComponentsPayouts Payouts { get; set; }
    }
}
