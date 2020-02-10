namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentCancelOptions : BaseOptions
    {
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
