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
        /// Configuration for the documents embedded component.
        /// </summary>
        [JsonProperty("documents")]
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

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
