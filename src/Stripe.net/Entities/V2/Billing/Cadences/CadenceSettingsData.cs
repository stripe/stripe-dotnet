// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettingsData : StripeEntity<CadenceSettingsData>
    {
        /// <summary>
        /// Expanded bill settings data with actual configuration values.
        /// </summary>
        [JsonProperty("bill")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill")]
#endif
        public CadenceSettingsDataBill Bill { get; set; }

        /// <summary>
        /// Expanded collection settings data with actual configuration values.
        /// </summary>
        [JsonProperty("collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection")]
#endif
        public CadenceSettingsDataCollection Collection { get; set; }
    }
}
