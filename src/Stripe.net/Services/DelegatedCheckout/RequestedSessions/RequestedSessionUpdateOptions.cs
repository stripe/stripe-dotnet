// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The details of the fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fulfillment_details")]
#endif
        public RequestedSessionFulfillmentDetailsOptions FulfillmentDetails { get; set; }

        /// <summary>
        /// The details of the line items.
        /// </summary>
        [JsonProperty("line_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item_details")]
#endif
        public List<RequestedSessionLineItemDetailOptions> LineItemDetails { get; set; }

        /// <summary>
        /// The metadata for this requested session.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payment method for this requested session.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment method data for this requested session.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public RequestedSessionPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// The shared metadata for this requested session.
        /// </summary>
        [JsonProperty("shared_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_metadata")]
#endif
        public Dictionary<string, string> SharedMetadata { get; set; }
    }
}
