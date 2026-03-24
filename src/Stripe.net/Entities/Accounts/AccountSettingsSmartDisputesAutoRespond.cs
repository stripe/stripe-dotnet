// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsSmartDisputesAutoRespond : StripeEntity<AccountSettingsSmartDisputesAutoRespond>
    {
        /// <summary>
        /// The preference setting for auto-respond. Can be 'on', 'off', or 'inherit'.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// The effective value for auto-respond. Can be 'on' or 'off'.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
