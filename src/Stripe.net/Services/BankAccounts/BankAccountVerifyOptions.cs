using Newtonsoft.Json;

namespace Stripe
{
    public class BankAccountVerifyOptions : StripeBaseOptions
    {
        [JsonProperty("amounts[]")]
        public int AmountOne { get; set; }

        [JsonProperty("amounts[]")]
        public int AmountTwo { get; set; }
    }
}
