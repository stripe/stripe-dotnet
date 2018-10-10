namespace Stripe
{
    using Newtonsoft.Json;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [JsonProperty("amounts")]
        public long[] Amounts { get; set; }
    }
}
