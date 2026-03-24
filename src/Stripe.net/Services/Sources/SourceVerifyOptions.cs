// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceVerifyOptions : BaseOptions
    {
        /// <summary>
        /// The values needed to verify the source.
        /// </summary>
        [JsonProperty("values")]
        [STJS.JsonPropertyName("values")]
        public List<string> Values { get; set; }
    }
}
