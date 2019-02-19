namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountUpdateOptions : AccountSharedOptions
    {
        [JsonProperty("individual")]
        public PersonUpdateOptions Individual { get; set; }
    }
}
