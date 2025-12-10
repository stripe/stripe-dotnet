// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities that enable the recipient to manage their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceOptions StripeBalance { get; set; }
    }
}
