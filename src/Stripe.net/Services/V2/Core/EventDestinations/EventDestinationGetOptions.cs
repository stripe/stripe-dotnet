// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventDestinationGetOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// </summary>
        [JsonProperty("include")]
        public List<string> Include { get; set; }
    }
}
