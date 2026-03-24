// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// <a href="https://stripe.com/docs/tax/tax-categories">Tax codes</a> classify goods and
    /// services for tax purposes.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxCode : StripeEntity<TaxCode>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// A detailed description of which types of products the tax code represents.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A short name for the tax code.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// An object that describes more information about the tax location required for this tax
        /// code. Some <a
        /// href="https://stripe.com/tax/tax-for-tickets/integration-guide#types-of-products">tax
        /// codes</a> require a tax location of type <c>performance</c> to calculate tax correctly.
        /// </summary>
        [JsonProperty("requirements")]
        [STJS.JsonPropertyName("requirements")]
        public TaxCodeRequirements Requirements { get; set; }
    }
}
