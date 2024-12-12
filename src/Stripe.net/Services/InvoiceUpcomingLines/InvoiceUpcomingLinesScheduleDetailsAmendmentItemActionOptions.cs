// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the subscription item to add. If an item with the same <c>price</c> exists,
        /// it will be replaced by this new item. Otherwise, it adds the new item.
        /// </summary>
        [JsonProperty("add")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionAddOptions Add { get; set; }

        /// <summary>
        /// Details of the subscription item to remove.
        /// </summary>
        [JsonProperty("remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details of the subscription item to replace the existing items with. If an item with the
        /// <c>set[price]</c> already exists, the <c>items</c> array is not cleared. Instead, all of
        /// the other <c>set</c> properties that are passed in this request will replace the
        /// existing values for the configuration item.
        /// </summary>
        [JsonProperty("set")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of item action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
