namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRejectOptions : BaseOptions
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
