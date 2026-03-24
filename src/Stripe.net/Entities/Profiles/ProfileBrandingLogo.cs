// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProfileBrandingLogo : StripeEntity<ProfileBrandingLogo>
    {
        [JsonProperty("original")]
        [STJS.JsonPropertyName("original")]
        public string Original { get; set; }
    }
}
