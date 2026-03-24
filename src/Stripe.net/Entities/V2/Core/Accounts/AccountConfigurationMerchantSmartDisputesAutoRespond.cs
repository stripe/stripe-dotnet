// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantSmartDisputesAutoRespond : StripeEntity<AccountConfigurationMerchantSmartDisputesAutoRespond>
    {
        /// <summary>
        /// The preference for automatic dispute responses.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// The effective value for automatic dispute responses.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
