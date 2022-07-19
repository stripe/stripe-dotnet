// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the subscription item to add.
        /// </summary>
        [JsonProperty("add")]
        public SubscriptionScheduleAmendmentItemActionAddOptions Add { get; set; }

        /// <summary>
        /// Details of the subscription item to remove.
        /// </summary>
        [JsonProperty("remove")]
        public SubscriptionScheduleAmendmentItemActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details of the subscription item to replace the existing items with.
        /// </summary>
        [JsonProperty("set")]
        public SubscriptionScheduleAmendmentItemActionSetOptions Set { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
