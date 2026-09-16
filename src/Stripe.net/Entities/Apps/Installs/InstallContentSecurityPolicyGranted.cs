// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InstallContentSecurityPolicyGranted : StripeEntity<InstallContentSecurityPolicyGranted>
    {
        [JsonProperty("connect_src")]
        [STJS.JsonPropertyName("connect_src")]
        public List<string> ConnectSrc { get; set; }

        [JsonProperty("image_src")]
        [STJS.JsonPropertyName("image_src")]
        public List<string> ImageSrc { get; set; }
    }
}
