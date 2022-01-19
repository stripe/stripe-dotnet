// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkLineItemOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// When set, provides configuration for this item’s quantity to be adjusted by the customer
        /// during checkout.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
        public PaymentLinkLineItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The ID of an existing line item on the payment link.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> or <a
        /// href="https://stripe.com/docs/api/plans">Plan</a> object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The quantity of the line item being purchased. Only <c>1</c> is supported.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
