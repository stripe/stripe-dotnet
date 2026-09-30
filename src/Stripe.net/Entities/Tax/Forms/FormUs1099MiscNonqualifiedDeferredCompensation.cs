// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099MiscNonqualifiedDeferredCompensation : StripeEntity<FormUs1099MiscNonqualifiedDeferredCompensation>
    {
        /// <summary>
        /// The signed adjustment included in the effective amount, as a decimal string. Only
        /// present for drafts.
        /// </summary>
        [JsonProperty("delta_decimal")]
        [STJS.JsonPropertyName("delta_decimal")]
        public string DeltaDecimal { get; set; }

        /// <summary>
        /// The effective amount in the form's currency, as a decimal string.
        /// </summary>
        [JsonProperty("volume_decimal")]
        [STJS.JsonPropertyName("volume_decimal")]
        public string VolumeDecimal { get; set; }
    }
}
