namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderReturnListOptions : ListOptionsWithCreated
    {
        [JsonProperty("order")]
        public string Order { get; set; }
    }
}
