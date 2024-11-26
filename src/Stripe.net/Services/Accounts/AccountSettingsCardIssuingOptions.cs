// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Details on the account's acceptance of the <a
        /// href="https://stripe.com/issuing/connect/tos_acceptance">Stripe Issuing Terms and
        /// Disclosures</a>.
        /// </summary>
        [JsonProperty("tos_acceptance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tos_acceptance")]
#endif
        public AccountSettingsCardIssuingTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
