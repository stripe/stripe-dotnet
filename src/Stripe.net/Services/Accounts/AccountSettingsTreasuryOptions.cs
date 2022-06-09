// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsTreasuryOptions : INestedOptions
    {
        /// <summary>
        /// Details on the account's acceptance of the Stripe Treasury Services Agreement.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        public AccountSettingsTreasuryTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
