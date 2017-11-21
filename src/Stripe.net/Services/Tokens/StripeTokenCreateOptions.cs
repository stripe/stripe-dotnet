using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTokenCreateOptions : StripeBaseOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("bank_account")]
        public BankAccountOptions BankAccount { get; set; }
    }
}