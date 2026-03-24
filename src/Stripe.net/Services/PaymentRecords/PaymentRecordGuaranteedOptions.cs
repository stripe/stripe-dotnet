// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordGuaranteedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment was guaranteed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("guaranteed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("guaranteed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? GuaranteedAt { get; set; }
    }
}
