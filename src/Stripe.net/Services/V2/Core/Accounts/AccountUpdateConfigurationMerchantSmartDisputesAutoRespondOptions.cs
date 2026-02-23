// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationMerchantSmartDisputesAutoRespondOptions : INestedOptions
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
    }
}
