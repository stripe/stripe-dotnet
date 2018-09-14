namespace Stripe
{
    using Newtonsoft.Json;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [JsonProperty("amounts[]")]
        public int AmountOne { get; set; }

        [JsonProperty("amounts[]")]
        public int AmountTwo { get; set; }
    }
}
