// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// <a href="https://stripe.com/docs/tax/tax-categories">Tax codes</a> classify goods and
    /// services for tax purposes.
    /// </summary>
    public class TaxCode : StripeEntity<TaxCode>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A detailed description of which types of products the tax code represents.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// A short name for the tax code.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// An object that describes more information about the tax location required for this tax
        /// code. Some <a
        /// href="https://stripe.com/tax/tax-for-tickets/integration-guide#types-of-products">tax
        /// codes</a> require a tax location of type <c>performance</c> to calculate tax correctly.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public TaxCodeRequirements Requirements { get; set; }
    }
}
