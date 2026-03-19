// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceLineItemPeriodOptions : INestedOptions
    {
        /// <summary>
        /// The end of the period, which must be greater than or equal to the start. This value is
        /// inclusive.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The start of the period. This value is inclusive.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Start { get; set; }
    }
}
