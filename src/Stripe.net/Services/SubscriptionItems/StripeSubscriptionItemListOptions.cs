namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeSubscriptionItemListOptions : StripeListOptions
    {
        /// <summary>
        /// REQUIRED: The ID of the subscription whose items will be retrieved.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}