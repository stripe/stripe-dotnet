namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceSepaDebit : StripeEntity<SourceSepaDebit>
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("branch_code")]
        public string BranchCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }

        [JsonProperty("mandate_url")]
        public string MandateUrl { get; set; }
    }
}
