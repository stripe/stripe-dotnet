// File generated from our OpenAPI spec
namespace Stripe.V2.Network
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BusinessProfileBrandingLogo : StripeEntity<BusinessProfileBrandingLogo>
    {
        /// <summary>
        /// The URL of the image in its original size.
        /// </summary>
        [JsonProperty("original")]
        [STJS.JsonPropertyName("original")]
        public string Original { get; set; }
    }
}
