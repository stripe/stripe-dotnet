// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsStaleLastReasonLinesInvalid : StripeEntity<QuoteStatusDetailsStaleLastReasonLinesInvalid>
    {
        /// <summary>
        /// The timestamp at which the lines were marked as invalid.
        /// </summary>
        [JsonProperty("invalid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invalid_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime InvalidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The list of lines that became invalid at the given timestamp.
        /// </summary>
        [JsonProperty("lines")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines")]
#endif
        public List<string> Lines { get; set; }
    }
}
