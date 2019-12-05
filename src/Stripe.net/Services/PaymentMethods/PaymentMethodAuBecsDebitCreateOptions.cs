namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodAuBecsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }
    }
}
