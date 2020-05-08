namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
