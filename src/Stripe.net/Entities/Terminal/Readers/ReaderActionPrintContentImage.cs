// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionPrintContentImage : StripeEntity<ReaderActionPrintContentImage>
    {
        /// <summary>
        /// Creation time of the object (in seconds since the Unix epoch).
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The original name of the uploaded file (e.g. <c>receipt.png</c>).
        /// </summary>
        [JsonProperty("filename")]
        [STJS.JsonPropertyName("filename")]
        public string Filename { get; set; }

        /// <summary>
        /// The size (in bytes) of the uploaded file.
        /// </summary>
        [JsonProperty("size")]
        [STJS.JsonPropertyName("size")]
        public long Size { get; set; }

        /// <summary>
        /// The format of the uploaded file.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
