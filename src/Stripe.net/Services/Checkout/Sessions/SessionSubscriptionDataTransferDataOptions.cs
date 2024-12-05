// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionSubscriptionDataTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the destination account. By default, the entire amount is transferred to the
        /// destination.
        /// </summary>
        [JsonProperty("amount_percent")]
        public decimal? AmountPercent { get; set; }

        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
