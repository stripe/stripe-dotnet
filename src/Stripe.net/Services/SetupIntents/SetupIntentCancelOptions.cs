namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentCancelOptions : BaseOptions
    {
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
