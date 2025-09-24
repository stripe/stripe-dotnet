// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettings : StripeEntity<CadenceSettings>
    {
        /// <summary>
        /// Settings that configure bills generation, which includes calculating totals, tax, and
        /// presenting invoices.
        /// </summary>
        [JsonProperty("bill")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill")]
#endif
        public CadenceSettingsBill Bill { get; set; }

        /// <summary>
        /// Settings that configure and manage the behavior of collecting payments.
        /// </summary>
        [JsonProperty("collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection")]
#endif
        public CadenceSettingsCollection Collection { get; set; }
    }
}
