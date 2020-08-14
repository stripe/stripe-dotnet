namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplePayDomainCreateOptions : BaseOptions
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
