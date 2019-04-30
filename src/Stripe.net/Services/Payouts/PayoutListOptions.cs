namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A filter on the list based on the object <c>arrival_date</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ArrivalDate { get; set; }

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
