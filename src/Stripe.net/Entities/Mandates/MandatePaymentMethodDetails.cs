namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        [JsonProperty("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
