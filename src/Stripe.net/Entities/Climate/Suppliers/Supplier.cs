// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A supplier of carbon removal.
    /// </summary>
    public class Supplier : StripeEntity<Supplier>, IHasId, IHasObject
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
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Link to a webpage to learn more about the supplier.
        /// </summary>
        [JsonProperty("info_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("info_url")]
#endif

        public string InfoUrl { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// The locations in which this supplier operates.
        /// </summary>
        [JsonProperty("locations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locations")]
#endif

        public List<SupplierLocation> Locations { get; set; }

        /// <summary>
        /// Name of this carbon removal supplier.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// The scientific pathway used for carbon removal.
        /// One of: <c>biomass_carbon_removal_and_storage</c>, <c>direct_air_capture</c>, or
        /// <c>enhanced_weathering</c>.
        /// </summary>
        [JsonProperty("removal_pathway")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("removal_pathway")]
#endif

        public string RemovalPathway { get; set; }
    }
}
