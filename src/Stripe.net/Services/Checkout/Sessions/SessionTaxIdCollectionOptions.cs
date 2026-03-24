// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Enable tax ID collection during checkout. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Describes whether a tax ID is required during checkout. Defaults to <c>never</c>. You
        /// can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
        [STJS.JsonPropertyName("required")]
        public string Required { get; set; }
    }
}
