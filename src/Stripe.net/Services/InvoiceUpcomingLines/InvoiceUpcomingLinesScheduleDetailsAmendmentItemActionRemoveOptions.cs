// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionRemoveOptions : INestedOptions
    {
        /// <summary>
        /// ID of a price to remove.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}
