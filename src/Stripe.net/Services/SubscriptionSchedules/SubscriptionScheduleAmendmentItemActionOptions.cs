// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the subscription item to add. If an item with the same <c>price</c> exists,
        /// it will be replaced by this new item. Otherwise, it adds the new item.
        /// </summary>
        [JsonProperty("add")]
        public SubscriptionScheduleAmendmentItemActionAddOptions Add { get; set; }

        /// <summary>
        /// Details of the subscription item to remove.
        /// </summary>
        [JsonProperty("remove")]
        public SubscriptionScheduleAmendmentItemActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details of the subscription item to replace the existing items with. If an item with the
        /// <c>set[price]</c> already exists, the <c>items</c> array is not cleared. Instead, all of
        /// the other <c>set</c> properties that are passed in this request will replace the
        /// existing values for the configuration item.
        /// </summary>
        [JsonProperty("set")]
        public SubscriptionScheduleAmendmentItemActionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of item action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
