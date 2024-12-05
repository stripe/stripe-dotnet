// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsPhaseItemTrialOptions : INestedOptions
    {
        /// <summary>
        /// List of price IDs which, if present on the subscription following a paid trial,
        /// constitute opting-in to the paid trial. Currently only supports at most 1 price ID.
        /// </summary>
        [JsonProperty("converts_to")]
        public List<string> ConvertsTo { get; set; }

        /// <summary>
        /// Determines the type of trial for this item.
        /// One of: <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
