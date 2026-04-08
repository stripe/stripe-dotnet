// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationClientDeviceMetadataDetailsDataOptions : INestedOptions
    {
        /// <summary>
        /// The IP address of the client device.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Pasted fields from the checkout flow.
        /// One of: <c>cvc</c>, <c>exp</c>, <c>number</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("pasted_fields")]
        [STJS.JsonPropertyName("pasted_fields")]
        public List<string> PastedFields { get; set; }

        /// <summary>
        /// The referrer of the client device.
        /// </summary>
        [JsonProperty("referrer")]
        [STJS.JsonPropertyName("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// The time on page in milliseconds.
        /// </summary>
        [JsonProperty("time_on_page_ms")]
        [STJS.JsonPropertyName("time_on_page_ms")]
        public long? TimeOnPageMs { get; set; }

        /// <summary>
        /// The user agent of the client device.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
