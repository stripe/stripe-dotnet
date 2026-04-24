// File generated from our OpenAPI spec
namespace Stripe.V2.Network
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The Stripe profile represents a business' public identity on the Stripe network.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BusinessProfile : StripeEntity<BusinessProfile>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the Stripe business profile; also known as the Network ID. This is the ID used
        /// to identify the business on the Stripe network.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Branding data for the business.
        /// </summary>
        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public BusinessProfileBranding Branding { get; set; }

        /// <summary>
        /// The description of the business.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the Stripe profile.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The URL of the business.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The username of the Stripe profile.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
