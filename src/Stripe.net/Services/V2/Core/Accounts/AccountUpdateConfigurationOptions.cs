// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationOptions : INestedOptions
    {
        /// <summary>
        /// The CardCreator Configuration allows the Account to create and issue cards to users.
        /// </summary>
        [JsonProperty("card_creator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_creator")]
#endif
        public AccountUpdateConfigurationCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// The Customer Configuration allows the Account to be charged.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public AccountUpdateConfigurationCustomerOptions Customer { get; set; }

        /// <summary>
        /// The Merchant configuration allows the Account to act as a connected account and collect
        /// payments facilitated by a Connect platform. You can add this configuration to your
        /// connected accounts only if you’ve completed onboarding as a Connect platform.
        /// </summary>
        [JsonProperty("merchant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant")]
#endif
        public AccountUpdateConfigurationMerchantOptions Merchant { get; set; }

        /// <summary>
        /// The Recipient Configuration allows the Account to receive funds.
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public AccountUpdateConfigurationRecipientOptions Recipient { get; set; }

        /// <summary>
        /// The Storer Configuration allows the Account to store and move funds using stored-value
        /// FinancialAccounts.
        /// </summary>
        [JsonProperty("storer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storer")]
#endif
        public AccountUpdateConfigurationStorerOptions Storer { get; set; }
    }
}
