namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [JsonProperty("amounts")]
        public List<long> Amounts { get; set; }
    }
}
