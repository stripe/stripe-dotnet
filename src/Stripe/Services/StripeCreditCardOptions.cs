using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCreditCardOptions
    {
        [JsonProperty("card")]
        public string TokenId { get; set; }

        [JsonProperty("card[number]")]
        public string CardNumber { get; set; }

        [JsonProperty("card[exp_month]")]
        public string CardExpirationMonth { get; set; }

        [JsonProperty("card[exp_year]")]
        public string CardExpirationYear { get; set; }

        [JsonProperty("card[cvc]")]
        public string CardCvc { get; set; }

        [JsonProperty("card[name]")]
        public string CardName { get; set; }

        [JsonProperty("card[address_line1]")]
        public string CardAddressLine1 { get; set; }

        [JsonProperty("card[address_line2]")]
        public string CardAddressLine2 { get; set; }

        [JsonProperty("card[address_zip]")]
        public string CardAddressZip { get; set; }

        [JsonProperty("card[address_city]")]
        public string CardAddressCity { get; set; }

        [JsonProperty("card[address_state]")]
        public string CardAddressState { get; set; }

        [JsonProperty("card[address_country]")]
        public string CardAddressCountry { get; set; }

        [JsonProperty("metadata")]
        public object MetaData { get; set; }
    }
}
