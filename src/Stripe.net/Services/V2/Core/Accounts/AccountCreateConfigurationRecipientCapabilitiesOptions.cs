// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationRecipientCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Capabilities that enable the recipient to manage their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceOptions StripeBalance { get; set; }
    }
}
