// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionBrandingSettingsLogoOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a <a href="https://stripe.com/docs/api/files">File upload</a> representing the
        /// logo. Purpose must be <c>business_logo</c>. Required if <c>type</c> is <c>file</c> and
        /// disallowed otherwise.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public string File { get; set; }

        /// <summary>
        /// The type of image for the logo. Must be one of <c>file</c> or <c>url</c>.
        /// One of: <c>file</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The URL of the image. Required if <c>type</c> is <c>url</c> and disallowed otherwise.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
