// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;

    public class SecretListOptions : ListOptions
    {
        [JsonProperty("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
