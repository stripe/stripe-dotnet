// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the account management embedded component.
        /// </summary>
        [JsonProperty("account_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_management")]
#endif
        public AccountSessionComponentsAccountManagementOptions AccountManagement { get; set; }

        /// <summary>
        /// Configuration for the account onboarding embedded component.
        /// </summary>
        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountSessionComponentsAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Configuration for the balances embedded component.
        /// </summary>
        [JsonProperty("balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balances")]
#endif
        public AccountSessionComponentsBalancesOptions Balances { get; set; }

        /// <summary>
        /// Configuration for the documents embedded component.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountSessionComponentsDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Configuration for the notification banner embedded component.
        /// </summary>
        [JsonProperty("notification_banner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("notification_banner")]
#endif
        public AccountSessionComponentsNotificationBannerOptions NotificationBanner { get; set; }

        /// <summary>
        /// Configuration for the payment details embedded component.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public AccountSessionComponentsPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// Configuration for the payments embedded component.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public AccountSessionComponentsPaymentsOptions Payments { get; set; }

        /// <summary>
        /// Configuration for the payouts embedded component.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountSessionComponentsPayoutsOptions Payouts { get; set; }

        /// <summary>
        /// Configuration for the payouts list embedded component.
        /// </summary>
        [JsonProperty("payouts_list")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts_list")]
#endif
        public AccountSessionComponentsPayoutsListOptions PayoutsList { get; set; }

        /// <summary>
        /// Configuration for the tax registrations embedded component.
        /// </summary>
        [JsonProperty("tax_registrations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_registrations")]
#endif
        public AccountSessionComponentsTaxRegistrationsOptions TaxRegistrations { get; set; }

        /// <summary>
        /// Configuration for the tax settings embedded component.
        /// </summary>
        [JsonProperty("tax_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_settings")]
#endif
        public AccountSessionComponentsTaxSettingsOptions TaxSettings { get; set; }
    }
}
