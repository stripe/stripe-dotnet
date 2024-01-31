// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class FeatureQuantity : StripeEntity<FeatureQuantity>
    {
        /// <summary>
        /// The quantity of units made available by this feature. This quantity will be multiplied
        /// by the line_item quantity for line_items that contain this feature.
        /// </summary>
        [JsonProperty("units_available")]
        public long UnitsAvailable { get; set; }
    }
}
