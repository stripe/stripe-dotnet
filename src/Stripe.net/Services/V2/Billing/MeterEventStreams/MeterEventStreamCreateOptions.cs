// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MeterEventStreamCreateOptions : BaseOptions
    {
        /// <summary>
        /// List of meter events to include in the request.
        /// </summary>
        [JsonProperty("events")]
        public List<MeterEventStreamCreateEventOptions> Events { get; set; }
    }
}
