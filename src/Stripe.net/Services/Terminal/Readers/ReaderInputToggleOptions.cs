// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderInputToggleOptions : INestedOptions
    {
        /// <summary>
        /// The default value of the toggle. Can be <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
        [STJS.JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The description which will be displayed for the toggle. Maximum 50 characters. At least
        /// one of title or description must be provided.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The title which will be displayed for the toggle. Maximum 50 characters. At least one of
        /// title or description must be provided.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
