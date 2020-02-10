namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandatePaymentMethodDetailsAuBecsDebit : StripeEntity<MandatePaymentMethodDetailsAuBecsDebit>
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
