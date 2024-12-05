// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionRemoveOptions : INestedOptions
    {
        /// <summary>
        /// ID of a price to remove.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}
