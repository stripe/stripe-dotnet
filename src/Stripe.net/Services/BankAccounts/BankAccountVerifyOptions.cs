namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BankAccountVerifyOptions : BaseOptions
    {
        [JsonProperty("amounts")]
        public List<long> Amounts { get; set; }
    }
}
