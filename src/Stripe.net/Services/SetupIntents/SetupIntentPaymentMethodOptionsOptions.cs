namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
