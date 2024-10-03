// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentSetPauseCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Details of the pause_collection behavior to apply to the amendment.
        /// </summary>
        [JsonProperty("set")]
        public InvoiceUpcomingLinesScheduleDetailsAmendmentSetPauseCollectionSetOptions Set { get; set; }

        /// <summary>
        /// Determines the type of the pause_collection amendment.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
