// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportParametersTimestampDetails : StripeEntity<ReportParametersTimestampDetails>
    {
        /// <summary>
        /// Maximum permitted timestamp which can be requested.
        /// </summary>
        [JsonProperty("max")]
        [STJS.JsonPropertyName("max")]
        public DateTime Max { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Minimum permitted timestamp which can be requested.
        /// </summary>
        [JsonProperty("min")]
        [STJS.JsonPropertyName("min")]
        public DateTime Min { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
