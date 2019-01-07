namespace Stripe
{
    using Newtonsoft.Json;

    public class ListOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// A cursor for use in pagination. <code>starting_after</code> is an object ID that defines
        /// your place in the list. For instance, if you make a list request and receive 100
        /// objects, ending with <code>obj_foo</code>, your subsequent call can include
        /// <code>starting_after=obj_foo</code> in order to fetch the next page of the list.
        /// </summary>
        [JsonProperty("starting_after")]
        public string StartingAfter { get; set; }

        /// <summary>
        /// A cursor for use in pagination. <code>ending_before</code> is an object ID that defines
        /// your place in the list. For instance, if you make a list request and receive 100
        /// objects, starting with <code>obj_bar</code>, your subsequent call can include
        /// <code>ending_before=obj_bar</code> in order to fetch the previous page of the list.
        /// </summary>
        [JsonProperty("ending_before")]
        public string EndingBefore { get; set; }
    }
}
