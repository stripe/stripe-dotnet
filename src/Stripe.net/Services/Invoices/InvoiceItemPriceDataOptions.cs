namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceItemPriceDataOptions : INestedOptions
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
        
        /// <summary>
        /// Specifies whether the price is considered inclusive of taxes or exclusive of taxes.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
