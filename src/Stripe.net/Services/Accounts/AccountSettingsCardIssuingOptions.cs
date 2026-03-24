// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Details on the account's acceptance of the <a
        /// href="https://stripe.com/issuing/connect/tos_acceptance">Stripe Issuing Terms and
        /// Disclosures</a>.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        [STJS.JsonPropertyName("tos_acceptance")]
        public AccountSettingsCardIssuingTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
