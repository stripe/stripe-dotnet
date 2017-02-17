using Newtonsoft.Json;

namespace Stripe.Services.Orders
{
    public class StripeStatusTransitionsFilter
    {
        /// <summary>
        /// Gets or sets the cancellation filter.
        /// </summary>
        [JsonProperty("canceled")]
        public StripeDateFilter CanceledFilter { get; set; }

        /// <summary>
        /// Gets or sets the fulfilment filter.
        /// </summary>
        [JsonProperty("fulfilled")]
        public StripeDateFilter FulfilledFilter { get; set; }

        /// <summary>
        /// Gets or sets the payment filter.
        /// </summary>
        [JsonProperty("paid")]
        public StripeDateFilter PaidFilter { get; set; }

        /// <summary>
        /// Gets or sets the return filter.
        /// </summary>
        [JsonProperty("returned")]
        public StripeDateFilter ReturnedFilter { get; set; }
    }
}
