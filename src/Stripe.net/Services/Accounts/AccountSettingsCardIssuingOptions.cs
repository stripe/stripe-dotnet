// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Details on the account's acceptance of the <a
        /// href="https://stripe.com/docs/issuing/connect/tos_acceptance">Stripe Issuing Terms and
        /// Disclosures</a>.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        public AccountSettingsCardIssuingTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
