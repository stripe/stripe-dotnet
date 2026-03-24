// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;
        private RequestedSessionPaymentMethodDataOptions paymentMethodData;
        private Dictionary<string, string> sharedMetadata;

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
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

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
        public RequestedSessionPaymentMethodDataOptions PaymentMethodData
        {
            get => this.paymentMethodData;
            set
            {
                this.paymentMethodData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The shared metadata for this requested session.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata
        {
            get => this.sharedMetadata;
            set
            {
                this.sharedMetadata = value;
                this.SetTracker.Track();
            }
        }
    }
}
