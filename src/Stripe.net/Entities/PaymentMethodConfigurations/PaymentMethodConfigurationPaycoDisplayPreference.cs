// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodConfigurationPaycoDisplayPreference : StripeEntity<PaymentMethodConfigurationPaycoDisplayPreference>
    {
        /// <summary>
        /// For child configs, whether or not the account's preference will be observed. If
        /// <c>false</c>, the parent configuration's default is used.
        /// </summary>
        [JsonProperty("overridable")]
        [STJS.JsonPropertyName("overridable")]
        public bool? Overridable { get; set; }

        /// <summary>
        /// The account's display preference.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// The effective display preference value.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
