// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Stripe profile.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Profile : StripeEntity<Profile>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the Stripe profile.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Branding information for the Stripe profile.
        /// </summary>
        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public ProfileBranding Branding { get; set; }

        /// <summary>
        /// A description of the business or entity represented by the Stripe profile.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name shown for the Stripe profile.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The external website URL associated with the Stripe profile.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The unique username for the Stripe profile.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
