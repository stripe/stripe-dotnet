namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceAcssDebit : StripeEntity<SourceAcssDebit>
    {
        [JsonProperty("bank_address_city")]
        public string BankAddressCity { get; set; }

        [JsonProperty("bank_address_line_1")]
        public string BankAddressLine1 { get; set; }

        [JsonProperty("bank_address_line_2")]
        public string BankAddressLine2 { get; set; }

        [JsonProperty("bank_address_postal_code")]
        public string BankAddressLinePostalCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
