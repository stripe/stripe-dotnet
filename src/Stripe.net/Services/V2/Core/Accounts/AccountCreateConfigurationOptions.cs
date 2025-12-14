// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationOptions : INestedOptions
    {
        /// <summary>
        /// The CardCreator Configuration allows the Account to create and issue cards to users.
        /// </summary>
        [JsonProperty("card_creator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_creator")]
#endif
        public AccountCreateConfigurationCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// The Customer Configuration allows the Account to be used in inbound payment flows.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public AccountCreateConfigurationCustomerOptions Customer { get; set; }

        /// <summary>
        /// Enables the Account to act as a connected account and collect payments facilitated by a
        /// Connect platform. You must onboard your platform to Connect before you can add this
        /// configuration to your connected accounts. Utilize this configuration when the Account
        /// will be the Merchant of Record, like with Direct charges or Destination Charges with
        /// on_behalf_of set.
        /// </summary>
        [JsonProperty("merchant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant")]
#endif
        public AccountCreateConfigurationMerchantOptions Merchant { get; set; }

        /// <summary>
        /// The Recipient Configuration allows the Account to receive funds. Utilize this
        /// configuration if the Account will not be the Merchant of Record, like with Separate
        /// Charges &amp; Transfers, or Destination Charges without on_behalf_of set.
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public AccountCreateConfigurationRecipientOptions Recipient { get; set; }

        /// <summary>
        /// The Storer Configuration allows the Account to store and move funds using stored-value
        /// FinancialAccounts.
        /// </summary>
        [JsonProperty("storer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storer")]
#endif
        public AccountCreateConfigurationStorerOptions Storer { get; set; }
    }
}
