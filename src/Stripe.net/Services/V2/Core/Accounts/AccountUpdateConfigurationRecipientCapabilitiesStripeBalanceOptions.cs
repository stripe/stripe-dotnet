// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationRecipientCapabilitiesStripeBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Enables this Account to receive /v1/transfers into their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("stripe_transfers")]
        [STJS.JsonPropertyName("stripe_transfers")]
        public AccountUpdateConfigurationRecipientCapabilitiesStripeBalanceStripeTransfersOptions StripeTransfers { get; set; }
    }
}
