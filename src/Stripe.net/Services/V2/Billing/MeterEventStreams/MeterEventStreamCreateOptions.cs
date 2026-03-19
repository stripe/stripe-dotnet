// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterEventStreamCreateOptions : BaseOptions
    {
        /// <summary>
        /// List of meter events to include in the request. Supports up to 100 events per request.
        /// </summary>
        [JsonProperty("events")]
        [STJS.JsonPropertyName("events")]
        public List<MeterEventStreamCreateEventOptions> Events { get; set; }
    }
}
