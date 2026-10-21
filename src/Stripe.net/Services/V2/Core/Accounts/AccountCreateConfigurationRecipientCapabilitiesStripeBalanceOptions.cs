// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationRecipientCapabilitiesStripeBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to hold USDC in their Stripe Balance via Bridge custodial wallets.
        /// </summary>
        [JsonProperty("stablecoin_custodial")]
        [STJS.JsonPropertyName("stablecoin_custodial")]
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceStablecoinCustodialOptions StablecoinCustodial { get; set; }

        /// <summary>
        /// Enables this Account to receive /v1/transfers into their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_transfers")]
        [STJS.JsonPropertyName("stripe_transfers")]
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceStripeTransfersOptions StripeTransfers { get; set; }
    }
}
