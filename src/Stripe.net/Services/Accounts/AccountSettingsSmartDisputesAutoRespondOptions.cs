// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsSmartDisputesAutoRespondOptions : INestedOptions
    {
        /// <summary>
        /// The preference setting for auto-respond. Can be 'on', 'off', or 'inherit'.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }
    }
}
