using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCreditCardOptions : StripeBaseOptions, INestedOptions
    {
        [JsonProperty("card")]
        public string TokenId { get; set; }

        [JsonProperty("card[exp_month]")]
        public int? ExpirationMonth { get; set; }

        [JsonProperty("card[exp_year]")]
        public int? ExpirationYear { get; set; }

        [JsonProperty("card[number]")]
        public string Number { get; set; }

        [JsonProperty("card[address_city]")]
        public string AddressCity { get; set; }

        [JsonProperty("card[address_country]")]
        public string AddressCountry { get; set; }

        [JsonProperty("card[address_line1]")]
        public string AddressLine1 { get; set; }

        [JsonProperty("card[address_line2]")]
        public string AddressLine2 { get; set; }

        [JsonProperty("card[address_state]")]
        public string AddressState { get; set; }

        [JsonProperty("card[address_zip]")]
        public string AddressZip { get; set; }

        [JsonProperty("card[currency]")]
        public string Currency { get; set; }

        [JsonProperty("card[cvc]")]
        public string Cvc { get; set; }

        [JsonProperty("card[name]")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public object MetaData { get; set; }
    }
}
