// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentDiscountActionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the discount to add.
        /// </summary>
        [JsonProperty("add")]
        public SubscriptionScheduleAmendmentDiscountActionAddOptions Add { get; set; }

        /// <summary>
        /// Details of the discount to remove.
        /// </summary>
        [JsonProperty("remove")]
        public SubscriptionScheduleAmendmentDiscountActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details of the discount to replace the existing discounts with.
        /// </summary>
        [JsonProperty("set")]
        public SubscriptionScheduleAmendmentDiscountActionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of discount action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
