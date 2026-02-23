// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantSmartDisputesAutoRespond : StripeEntity<AccountConfigurationMerchantSmartDisputesAutoRespond>
    {
        /// <summary>
        /// The preference for automatic dispute responses.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preference")]
#endif
        public string Preference { get; set; }

        /// <summary>
        /// The effective value for automatic dispute responses.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
