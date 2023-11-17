// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the account onboarding embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the issuing card component.
        /// </summary>
        [JsonProperty("issuing_card")]
        public AccountSessionComponentsIssuingCardOptions IssuingCard { get; set; }

        /// <summary>
        /// Configuration for the issuing cards list component.
        /// </summary>
        [JsonProperty("issuing_cards_list")]
        public AccountSessionComponentsIssuingCardsListOptions IssuingCardsList { get; set; }

        /// <summary>
        /// Configuration for the payment details embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the payments embedded component.
        /// </summary>
        [JsonProperty("payments")]
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the payouts embedded component.
        /// </summary>
        [JsonProperty("payouts")]
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }
    }
}
