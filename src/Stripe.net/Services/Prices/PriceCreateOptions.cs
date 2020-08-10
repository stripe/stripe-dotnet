namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("product_data")]
        public PriceProductDataOptions ProductData { get; set; }

        [JsonProperty("recurring")]
        public PriceRecurringOptions Recurring { get; set; }

        [JsonProperty("tiers")]
        public List<PriceTierOptions> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }

        [JsonProperty("transform_quantity")]
        public PriceTransformQuantityOptions TransformQuantity { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
