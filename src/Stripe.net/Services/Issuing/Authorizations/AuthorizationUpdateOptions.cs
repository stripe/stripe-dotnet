namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
