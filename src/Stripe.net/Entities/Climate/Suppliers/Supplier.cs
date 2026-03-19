// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A supplier of carbon removal.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Supplier : StripeEntity<Supplier>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Link to a webpage to learn more about the supplier.
        /// </summary>
        [JsonProperty("info_url")]
        [STJS.JsonPropertyName("info_url")]
        public string InfoUrl { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The locations in which this supplier operates.
        /// </summary>
        [JsonProperty("locations")]
        [STJS.JsonPropertyName("locations")]
        public List<SupplierLocation> Locations { get; set; }

        /// <summary>
        /// Name of this carbon removal supplier.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The scientific pathway used for carbon removal.
        /// One of: <c>biomass_carbon_removal_and_storage</c>, <c>direct_air_capture</c>, or
        /// <c>enhanced_weathering</c>.
        /// </summary>
        [JsonProperty("removal_pathway")]
        [STJS.JsonPropertyName("removal_pathway")]
        public string RemovalPathway { get; set; }
    }
}
