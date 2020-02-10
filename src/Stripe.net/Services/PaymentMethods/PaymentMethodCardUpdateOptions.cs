namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCardUpdateOptions : INestedOptions
    {
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }
    }
}
