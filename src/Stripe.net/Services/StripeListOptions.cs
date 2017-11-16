using Newtonsoft.Json;

namespace Stripe
{
    public class StripeListOptions : StripeBaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned. Limit can range between 1 and 100 items.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// A cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include starting_after=obj_foo in order to fetch the next page of the list.
        /// </summary>
        [JsonProperty("starting_after")]
        public string StartingAfter { get; set; }

        /// <summary>
        /// A cursor for use in pagination. ending_before is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, starting with obj_bar, your subsequent call can include ending_before=obj_bar in order to fetch the previous page of the list.
        /// </summary>
        [JsonProperty("ending_before")]
        public string EndingBefore { get; set; }
    }
}