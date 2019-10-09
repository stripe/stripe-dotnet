namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditCardOptions : BaseOptions, INestedOptions
    {
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        /* Issuing-specific parameter */

        /// <summary>
        /// This parameter is used to create a Source from an issuing card mostly in Test mode.
        /// </summary>
        [JsonProperty("issuing_card")]
        public string IssuingCard { get; set; }
    }
}
