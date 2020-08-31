namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleCancelOptions : BaseOptions
    {
        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if a final invoice will be
        /// generated that contains any un-invoiced metered usage and new/pending proration invoice
        /// items. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if the cancellation should be
        /// prorated. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
