namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentSourceListOptions : ListOptions
    {
        /// <summary>Filter sources according to a particular object type.</summary>
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
