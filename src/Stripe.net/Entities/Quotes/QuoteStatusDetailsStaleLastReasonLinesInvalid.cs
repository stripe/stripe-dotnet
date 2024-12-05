// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteStatusDetailsStaleLastReasonLinesInvalid : StripeEntity<QuoteStatusDetailsStaleLastReasonLinesInvalid>
    {
        /// <summary>
        /// The timestamp at which the lines were marked as invalid.
        /// </summary>
        [JsonProperty("invalid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime InvalidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The list of lines that became invalid at the given timestamp.
        /// </summary>
        [JsonProperty("lines")]
        public List<string> Lines { get; set; }
    }
}
