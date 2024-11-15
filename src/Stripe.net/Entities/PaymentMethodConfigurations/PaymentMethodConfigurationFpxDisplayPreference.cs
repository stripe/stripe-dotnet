// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodConfigurationFpxDisplayPreference : StripeEntity<PaymentMethodConfigurationFpxDisplayPreference>
    {
        /// <summary>
        /// For child configs, whether or not the account's preference will be observed. If
        /// <c>false</c>, the parent configuration's default is used.
        /// </summary>
        [JsonProperty("overridable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("overridable")]
#endif

        public bool? Overridable { get; set; }

        /// <summary>
        /// The account's display preference.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preference")]
#endif

        public string Preference { get; set; }

        /// <summary>
        /// The effective display preference value.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif

        public string Value { get; set; }
    }
}
