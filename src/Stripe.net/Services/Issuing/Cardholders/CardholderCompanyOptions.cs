namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderCompanyOptions : INestedOptions
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
