namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class ListOptions : BaseOptions
    {
        /// <summary>
        /// A limit on the number of objects to be returned, between 1 and 100.
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }
    }
}
