namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use CustomerTaxIdDataOptions instead.")]
    public class CustomerTaxInfoOptions : INestedOptions
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
