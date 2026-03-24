// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Return results where the <c>created</c> field is greater than this value.
        /// </summary>
        [JsonProperty("gt")]
        [STJS.JsonPropertyName("gt")]
        public long? Gt { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is greater than or equal to this value.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public long? Gte { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is less than this value.
        /// </summary>
        [JsonProperty("lt")]
        [STJS.JsonPropertyName("lt")]
        public long? Lt { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is less than or equal to this value.
        /// </summary>
        [JsonProperty("lte")]
        [STJS.JsonPropertyName("lte")]
        public long? Lte { get; set; }
    }
}
