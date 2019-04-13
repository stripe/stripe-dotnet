namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use Customer.TaxIds instead.")]
    public class CustomerTaxInfo : StripeEntity
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
