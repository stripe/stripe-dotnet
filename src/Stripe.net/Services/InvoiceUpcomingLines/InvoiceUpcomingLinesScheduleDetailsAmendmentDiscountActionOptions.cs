// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the discount to add.
        /// </summary>
        [JsonProperty("add")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionAddOptions Add { get; set; }

        /// <summary>
        /// Details of the discount to remove.
        /// </summary>
        [JsonProperty("remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// Details of the discount to replace the existing discounts with.
        /// </summary>
        [JsonProperty("set")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of discount action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
