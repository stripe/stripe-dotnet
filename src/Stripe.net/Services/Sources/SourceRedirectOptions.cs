namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceRedirectOptions : INestedOptions
    {
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
