namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A filter on the list based on the object <c>arrival_date</c> field.
        /// </summary>
        [JsonProperty("arrival_date")]
        public DateTime? ArrivalDate { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>arrival_date</c> field.
        /// </summary>
        [JsonProperty("arrival_date")]
        public DateRangeOptions ArrivalDateRange { get; set; }

        /// <summary>
        /// The ID of an external account - only return payouts sent to this external account.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Only return payouts that have the given status: <c>pending</c>, <c>paid</c>,
        /// <c>failed</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
