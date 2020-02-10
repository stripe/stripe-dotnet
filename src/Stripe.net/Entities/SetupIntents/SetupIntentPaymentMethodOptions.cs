namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
