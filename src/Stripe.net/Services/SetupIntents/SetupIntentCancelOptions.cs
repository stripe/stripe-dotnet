namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentCancelOptions : BaseOptions
    {
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
