// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterEventStreamCreateOptions : BaseOptions
    {
        /// <summary>
        /// List of meter events to include in the request. Supports up to 100 events per request.
        /// </summary>
        [JsonProperty("events")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("events")]
#endif
        public List<MeterEventStreamCreateEventOptions> Events { get; set; }
    }
}
