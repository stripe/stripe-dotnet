namespace Stripe
{
    using Newtonsoft.Json;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [JsonProperty("amounts")]
        public int[] Amounts { get; set; }
    }
}
