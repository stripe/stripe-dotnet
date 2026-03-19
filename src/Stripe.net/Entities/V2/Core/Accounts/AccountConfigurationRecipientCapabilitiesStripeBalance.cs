// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilitiesStripeBalance : StripeEntity<AccountConfigurationRecipientCapabilitiesStripeBalance>
    {
        /// <summary>
        /// Enables this Account to complete payouts from their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountConfigurationRecipientCapabilitiesStripeBalancePayouts Payouts { get; set; }

        /// <summary>
        /// Enables this Account to receive /v1/transfers into their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_transfers")]
        [STJS.JsonPropertyName("stripe_transfers")]
        public AccountConfigurationRecipientCapabilitiesStripeBalanceStripeTransfers StripeTransfers { get; set; }
    }
}
