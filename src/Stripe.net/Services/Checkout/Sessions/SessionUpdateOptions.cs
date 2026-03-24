// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionUpdateOptions : BaseOptions, IHasMetadata
    {
        private List<SessionDiscountOptions> discounts;
        private Dictionary<string, string> metadata;
        private List<SessionShippingOptionOptions> shippingOptions;

        /// <summary>
        /// Settings for automatic tax lookup for this session and resulting payments, invoices, and
        /// subscriptions.
        /// </summary>
        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public SessionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Information about the customer collected within the Checkout Session. Can only be set
        /// when updating <c>embedded</c> or <c>custom</c> sessions.
        /// </summary>
        [JsonProperty("collected_information")]
        [STJS.JsonPropertyName("collected_information")]
        public SessionCollectedInformationOptions CollectedInformation { get; set; }

        /// <summary>
        /// List of coupons and promotion codes attached to the Checkout Session.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SessionDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Generate a post-purchase Invoice for one-time payments.
        /// </summary>
        [JsonProperty("invoice_creation")]
        [STJS.JsonPropertyName("invoice_creation")]
        public SessionInvoiceCreationOptions InvoiceCreation { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing.
        ///
        /// When updating line items, you must retransmit the entire array of line items.
        ///
        /// To retain an existing line item, specify its <c>id</c>.
        ///
        /// To update an existing line item, specify its <c>id</c> along with the new values of the
        /// fields to update.
        ///
        /// To add a new line item, specify one of <c>price</c> or <c>price_data</c> and
        /// <c>quantity</c>.
        ///
        /// To remove an existing line item, omit the line item's ID from the retransmitted array.
        ///
        /// To reorder a line item, specify it at the desired position in the retransmitted array.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<SessionLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
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
        /// The shipping rate options to apply to this Session. Up to a maximum of 5.
        /// </summary>
        [JsonProperty("shipping_options")]
        [STJS.JsonPropertyName("shipping_options")]
        public List<SessionShippingOptionOptions> ShippingOptions
        {
            get => this.shippingOptions;
            set
            {
                this.shippingOptions = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A subset of parameters to be passed to subscription creation for Checkout Sessions in
        /// <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("subscription_data")]
        [STJS.JsonPropertyName("subscription_data")]
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }
    }
}
