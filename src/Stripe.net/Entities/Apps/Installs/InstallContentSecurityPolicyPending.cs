// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InstallContentSecurityPolicyPending : StripeEntity<InstallContentSecurityPolicyPending>
    {
        /// <summary>
        /// The URLs that the app can make network requests to.
        /// </summary>
        [JsonProperty("connect_src")]
        [STJS.JsonPropertyName("connect_src")]
        public List<string> ConnectSrc { get; set; }

        /// <summary>
        /// The URLs that the app can load images from.
        /// </summary>
        [JsonProperty("image_src")]
        [STJS.JsonPropertyName("image_src")]
        public List<string> ImageSrc { get; set; }
    }
}
