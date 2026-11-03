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
        /// Use this capability if the Account will not be the Merchant of Record, like with
        /// Separate Charges &amp; Transfers, or Destination Charges without on_behalf_of set.
        /// </summary>
        [JsonProperty("stripe_transfers")]
        [STJS.JsonPropertyName("stripe_transfers")]
        public AccountUpdateConfigurationRecipientCapabilitiesStripeBalanceStripeTransfersOptions StripeTransfers { get; set; }
    }
}
