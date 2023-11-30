// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A supplier of carbon removal.
    /// </summary>
    public class Supplier : StripeEntity<Supplier>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Link to a webpage to learn more about the supplier.
        /// </summary>
        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The locations in which this supplier operates.
        /// </summary>
        [JsonProperty("locations")]
        public List<SupplierLocation> Locations { get; set; }

        /// <summary>
        /// Name of this carbon removal supplier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The scientific pathway used for carbon removal.
        /// One of: <c>biomass_carbon_removal_and_storage</c>, <c>direct_air_capture</c>,
        /// <c>enhanced_weathering</c>, or <c>various</c>.
        /// </summary>
        [JsonProperty("removal_pathway")]
        public string RemovalPathway { get; set; }
    }
}
