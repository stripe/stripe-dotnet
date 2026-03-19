// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfiguration : StripeEntity<AccountConfiguration>
    {
        /// <summary>
        /// The Customer Configuration allows the Account to be used in inbound payment flows.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public AccountConfigurationCustomer Customer { get; set; }

        /// <summary>
        /// Enables the Account to act as a connected account and collect payments facilitated by a
        /// Connect platform. You must onboard your platform to Connect before you can add this
        /// configuration to your connected accounts. Utilize this configuration when the Account
        /// will be the Merchant of Record, like with Direct charges or Destination Charges with
        /// on_behalf_of set.
        /// </summary>
        [JsonProperty("merchant")]
        [STJS.JsonPropertyName("merchant")]
        public AccountConfigurationMerchant Merchant { get; set; }

        /// <summary>
        /// The Recipient Configuration allows the Account to receive funds. Utilize this
        /// configuration if the Account will not be the Merchant of Record, like with Separate
        /// Charges &amp; Transfers, or Destination Charges without on_behalf_of set.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public AccountConfigurationRecipient Recipient { get; set; }
    }
}
