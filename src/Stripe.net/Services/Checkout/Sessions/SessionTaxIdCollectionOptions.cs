// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Enable tax ID collection during checkout. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// Describes whether a tax ID is required during checkout. Defaults to <c>never</c>. You
        /// can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required")]
#endif
        public string Required { get; set; }
    }
}
