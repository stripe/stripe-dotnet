// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunResultFileDownloadUrl : StripeEntity<ReportRunResultFileDownloadUrl>
    {
        /// <summary>
        /// The time that the URL expires.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL that can be used for accessing the file.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
