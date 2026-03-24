// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionBrandingSettingsLogoOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a <a href="https://stripe.com/docs/api/files">File upload</a> representing the
        /// logo. Purpose must be <c>business_logo</c>. Required if <c>type</c> is <c>file</c> and
        /// disallowed otherwise.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// The type of image for the logo. Must be one of <c>file</c> or <c>url</c>.
        /// One of: <c>file</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The URL of the image. Required if <c>type</c> is <c>url</c> and disallowed otherwise.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
