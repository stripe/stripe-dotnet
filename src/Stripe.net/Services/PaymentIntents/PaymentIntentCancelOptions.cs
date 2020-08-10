namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentCancelOptions : BaseOptions
    {
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
