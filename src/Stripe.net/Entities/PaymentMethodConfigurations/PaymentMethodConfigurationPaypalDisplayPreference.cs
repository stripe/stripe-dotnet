// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationPaypalDisplayPreference : StripeEntity<PaymentMethodConfigurationPaypalDisplayPreference>
    {
        /// <summary>
        /// For child configs, whether or not the account's preference will be observed. If
        /// <c>false</c>, the parent configuration's default is used.
        /// </summary>
        [JsonProperty("overridable")]
        public bool? Overridable { get; set; }

        /// <summary>
        /// The account's display preference.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        public string Preference { get; set; }

        /// <summary>
        /// The effective display preference value.
        /// One of: <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
