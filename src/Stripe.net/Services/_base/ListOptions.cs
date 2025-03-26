namespace Stripe
{
    using Newtonsoft.Json;

#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ListOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limit")]
#endif
        public long? Limit { get; set; }

        /// <summary>
        /// A cursor for use in pagination. <c>starting_after</c> is an object ID that defines
        /// your place in the list. For instance, if you make a list request and receive 100
        /// objects, ending with <c>obj_foo</c>, your subsequent call can include
        /// <c>starting_after=obj_foo</c> in order to fetch the next page of the list.
        /// </summary>
        [JsonProperty("starting_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starting_after")]
#endif
        public string StartingAfter { get; set; }

        /// <summary>
        /// A cursor for use in pagination. <c>ending_before</c> is an object ID that defines
        /// your place in the list. For instance, if you make a list request and receive 100
        /// objects, starting with <c>obj_bar</c>, your subsequent call can include
        /// <c>ending_before=obj_bar</c> in order to fetch the previous page of the list.
        /// </summary>
        [JsonProperty("ending_before")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ending_before")]
#endif
        public string EndingBefore { get; set; }
    }
}
