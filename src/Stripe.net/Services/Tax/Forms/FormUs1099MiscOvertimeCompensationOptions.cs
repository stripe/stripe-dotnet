// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUs1099MiscOvertimeCompensationOptions : INestedOptions
    {
        /// <summary>
        /// The replacement amount in major currency units, with at most two decimal places. Must be
        /// non-negative.
        /// </summary>
        [JsonProperty("volume_decimal")]
        [STJS.JsonPropertyName("volume_decimal")]
        public string VolumeDecimal { get; set; }
    }
}
