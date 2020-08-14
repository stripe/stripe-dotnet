namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleCancelOptions : BaseOptions
    {
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
