namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("card")]
        public CreditCardOptions Card { get; set; }

        [JsonProperty("bank_account")]
        public BankAccountOptions BankAccount { get; set; }
    }
}