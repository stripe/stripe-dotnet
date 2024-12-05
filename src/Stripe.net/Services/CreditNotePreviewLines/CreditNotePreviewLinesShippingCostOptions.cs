// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNotePreviewLinesShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the shipping rate to use for this order.
        /// </summary>
        [JsonProperty("shipping_rate")]
        public string ShippingRate { get; set; }
    }
}
