// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductIdentifiers : StripeEntity<ProductIdentifiers>
    {
        /// <summary>
        /// European Article Number (EAN) consisting of 8 or 13 digits and optional dashes. You may
        /// optionally provide a leading 0 for a total of 14 digits. The final digit is a validated
        /// check digit.
        /// </summary>
        [JsonProperty("ean")]
        [STJS.JsonPropertyName("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// Global Trade Item Number (GTIN) consisting of 8, 12, 13, or 14 digits and optional
        /// dashes. The final digit is a validated check digit.
        /// </summary>
        [JsonProperty("gtin")]
        [STJS.JsonPropertyName("gtin")]
        public string Gtin { get; set; }

        /// <summary>
        /// International Standard Book Number (ISBN) consisting of 10 or 13 digits and optional
        /// dashes. The final digit is a validated check digit. For ISBN-10, the final digit may be
        /// a <c>X</c>.
        /// </summary>
        [JsonProperty("isbn")]
        [STJS.JsonPropertyName("isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// Japanese Article Number (JAN) consisting of 13 digits and optional dashes. The first two
        /// digits must either be <c>45</c> or <c>49</c>. The final digit is a validated check
        /// digit.
        /// </summary>
        [JsonProperty("jan")]
        [STJS.JsonPropertyName("jan")]
        public string Jan { get; set; }

        /// <summary>
        /// Manufacturer Part Number (MPN). May include up to 70 alphanumeric characters and dashes.
        /// </summary>
        [JsonProperty("mpn")]
        [STJS.JsonPropertyName("mpn")]
        public string Mpn { get; set; }

        /// <summary>
        /// National Stock Number (NSN) consisting of 13 digits and optional dashes. The seventh
        /// character may also be alphanumeric.
        /// </summary>
        [JsonProperty("nsn")]
        [STJS.JsonPropertyName("nsn")]
        public string Nsn { get; set; }

        /// <summary>
        /// Universal Product Code (UPC) consisting of 12 digits and optional dashes. The final
        /// digit is a validated check digit.
        /// </summary>
        [JsonProperty("upc")]
        [STJS.JsonPropertyName("upc")]
        public string Upc { get; set; }
    }
}
