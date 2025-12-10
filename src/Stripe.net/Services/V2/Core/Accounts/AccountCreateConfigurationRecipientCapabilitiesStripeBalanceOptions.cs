// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientCapabilitiesStripeBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to receive /v1/transfers into their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_transfers")]
#endif
        public AccountCreateConfigurationRecipientCapabilitiesStripeBalanceStripeTransfersOptions StripeTransfers { get; set; }
    }
}
