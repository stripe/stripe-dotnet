// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsData : StripeEntity<CadenceSettingsData>
    {
        /// <summary>
        /// Expanded bill settings data with actual configuration values.
        /// </summary>
        [JsonProperty("bill")]
        [STJS.JsonPropertyName("bill")]
        public CadenceSettingsDataBill Bill { get; set; }

        /// <summary>
        /// Expanded collection settings data with actual configuration values.
        /// </summary>
        [JsonProperty("collection")]
        [STJS.JsonPropertyName("collection")]
        public CadenceSettingsDataCollection Collection { get; set; }
    }
}
