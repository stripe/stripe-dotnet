using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderUpdateOptions : StripeOrderUpsertOptionsBase
    {
        /// <summary>
        /// Gets or sets the shipping method to select for fulfilling this order. If specified, must be one of the ids of a shipping method in the shipping_methods array. If specified, will overwrite the existing selected shipping method, updating items as necessary.
        /// </summary>
        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// Gets or sets Current order status. One of created, paid, canceled, fulfilled, or returned. More detail in the Relay API Overview.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
