// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportParametersTimestampDetails : StripeEntity<ReportParametersTimestampDetails>
    {
        /// <summary>
        /// Maximum permitted timestamp which can be requested.
        /// </summary>
        [JsonProperty("max")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max")]
#endif
        public DateTime Max { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Minimum permitted timestamp which can be requested.
        /// </summary>
        [JsonProperty("min")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("min")]
#endif
        public DateTime Min { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
