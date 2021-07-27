// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxCode : StripeEntity<TaxCode>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A detailed description of which types of products the tax code represents.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A short name for the tax code.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
