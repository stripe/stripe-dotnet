// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceDataSettings : StripeEntity<IntentCadenceDataSettings>
    {
        /// <summary>
        /// Settings that configure bills generation, which includes calculating totals, tax, and
        /// presenting invoices.
        /// </summary>
        [JsonProperty("bill")]
        [STJS.JsonPropertyName("bill")]
        public IntentCadenceDataSettingsBill Bill { get; set; }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments.
        /// </summary>
        [JsonProperty("collection")]
        [STJS.JsonPropertyName("collection")]
        public IntentCadenceDataSettingsCollection Collection { get; set; }
    }
}
