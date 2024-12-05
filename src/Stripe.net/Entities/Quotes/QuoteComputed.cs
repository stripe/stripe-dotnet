// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteComputed : StripeEntity<QuoteComputed>
    {
        /// <summary>
        /// Details of the most recent reestimate of the quote's preview schedules and upcoming
        /// invoices, including the status of Stripe's calculation.
        /// </summary>
        [JsonProperty("last_reestimation_details")]
        public QuoteComputedLastReestimationDetails LastReestimationDetails { get; set; }

        /// <summary>
        /// The definitive totals and line items the customer will be charged on a recurring basis.
        /// Takes into account the line items with recurring prices and discounts with
        /// <c>duration=forever</c> coupons only. Defaults to <c>null</c> if no inputted line items
        /// with recurring prices.
        /// </summary>
        [JsonProperty("recurring")]
        public QuoteComputedRecurring Recurring { get; set; }

        /// <summary>
        /// The time at which the quote's estimated schedules and upcoming invoices were generated.
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("upfront")]
        public QuoteComputedUpfront Upfront { get; set; }
    }
}
