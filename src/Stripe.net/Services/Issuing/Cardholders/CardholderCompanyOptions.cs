namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderCompanyOptions : INestedOptions
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
