// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormPayeeDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The payee's replacement address fields. Omitted fields remain unchanged.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The payee's merchant category code.
        /// </summary>
        [JsonProperty("merchant_category_code")]
        [STJS.JsonPropertyName("merchant_category_code")]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// The first line of the payee's name.
        /// </summary>
        [JsonProperty("name_line_1")]
        [STJS.JsonPropertyName("name_line_1")]
        public string NameLine1 { get; set; }

        /// <summary>
        /// The second line of the payee's name. An empty string clears this field.
        /// </summary>
        [JsonProperty("name_line_2")]
        [STJS.JsonPropertyName("name_line_2")]
        public string NameLine2 { get; set; }

        /// <summary>
        /// The payee's US taxpayer identification number.
        /// </summary>
        [JsonProperty("tax_id_number")]
        [STJS.JsonPropertyName("tax_id_number")]
        public string TaxIdNumber { get; set; }

        /// <summary>
        /// The payee's Treasury tipped occupation code, where supported by the reporting year and
        /// form type.
        /// </summary>
        [JsonProperty("treasury_tipped_occupation_code")]
        [STJS.JsonPropertyName("treasury_tipped_occupation_code")]
        public string TreasuryTippedOccupationCode { get; set; }
    }
}
