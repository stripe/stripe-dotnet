// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProfileBrandingLogo : StripeEntity<ProfileBrandingLogo>
    {
        [JsonProperty("original")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original")]
#endif
        public string Original { get; set; }
    }
}
