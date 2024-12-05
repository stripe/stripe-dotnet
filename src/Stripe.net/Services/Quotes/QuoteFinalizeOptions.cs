// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteFinalizeOptions : BaseOptions
    {
        /// <summary>
        /// A future timestamp on which the quote will be canceled if in <c>open</c> or <c>draft</c>
        /// status. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
    }
}
