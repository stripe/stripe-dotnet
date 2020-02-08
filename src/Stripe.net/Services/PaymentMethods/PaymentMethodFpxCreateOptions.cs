namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodFpxCreateOptions : INestedOptions
    {
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
