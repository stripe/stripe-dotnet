namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerTaxIdDataOptions : INestedOptions
    {
        /// <summary>
        /// Type of the tax ID, one of <c>eu_vat</c>, <c>nz_gst</c> or <c>au_abn</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
