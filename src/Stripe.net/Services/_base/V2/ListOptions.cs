namespace Stripe.V2
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class ListOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
        [STJS.JsonPropertyName("limit")]
        public long? Limit { get; set; }
    }
}
