// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attribution")]
        [STJS.JsonPropertyName("affiliate_attribution")]
        public RequestedSessionAffiliateAttributionOptions AffiliateAttribution { get; set; }

        /// <summary>
        /// The currency for this requested session.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer for this requested session.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The details of the fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_details")]
        [STJS.JsonPropertyName("fulfillment_details")]
        public RequestedSessionFulfillmentDetailsOptions FulfillmentDetails { get; set; }

        /// <summary>
        /// The details of the line items.
        /// </summary>
        [JsonProperty("line_item_details")]
        [STJS.JsonPropertyName("line_item_details")]
        public List<RequestedSessionLineItemDetailOptions> LineItemDetails { get; set; }

        /// <summary>
        /// The metadata for this requested session.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payment method for this requested session.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment method data for this requested session.
        /// </summary>
        [JsonProperty("payment_method_data")]
        [STJS.JsonPropertyName("payment_method_data")]
        public RequestedSessionPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// The details of the seller.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public RequestedSessionSellerDetailsOptions SellerDetails { get; set; }

        /// <summary>
        /// The setup future usage for this requested session.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// The shared metadata for this requested session.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }
    }
}
