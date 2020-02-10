namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentGetOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
