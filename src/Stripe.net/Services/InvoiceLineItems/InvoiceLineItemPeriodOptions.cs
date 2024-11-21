// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemPeriodOptions : INestedOptions
    {
        /// <summary>
        /// The end of the period, which must be greater than or equal to the start. This value is
        /// inclusive.
        /// </summary>
        [JsonProperty("end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? End { get; set; }

        /// <summary>
        /// The start of the period. This value is inclusive.
        /// </summary>
        [JsonProperty("start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? Start { get; set; }
    }
}
