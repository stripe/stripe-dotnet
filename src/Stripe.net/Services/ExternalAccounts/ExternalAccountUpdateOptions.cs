namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExternalAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

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

        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
