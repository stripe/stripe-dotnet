// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordListOptions : ListOptions
    {
        /// <summary>
        /// Only return Payment Records that were created after this unix timestamp.
        /// </summary>
        [JsonProperty("created_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Only return Payment Records that were created before this unix timestamp.
        /// </summary>
        [JsonProperty("created_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CreatedBefore { get; set; }
    }
}
