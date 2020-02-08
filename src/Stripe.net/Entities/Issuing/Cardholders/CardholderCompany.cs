namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
