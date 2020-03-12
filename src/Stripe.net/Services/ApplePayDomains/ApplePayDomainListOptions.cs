namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplePayDomainListOptions : ListOptions
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
    }
}
