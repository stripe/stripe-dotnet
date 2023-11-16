// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBacsDebitPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// The Bacs Direct Debit Display Name for this account. For payments made with Bacs Direct
        /// Debit, this name appears on the mandate as the statement descriptor. Mobile banking apps
        /// display it as the name of the business. To use custom branding, set the Bacs Direct
        /// Debit Display Name during or right after creation. Custom branding incurs an additional
        /// monthly fee for the platform. If you don't set the display name before requesting Bacs
        /// capability, it's automatically set as "Stripe" and the account is onboarded to Stripe
        /// branding, which is free.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
