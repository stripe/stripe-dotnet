// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the payment link's <c>url</c> is active. If <c>false</c>, customers visiting the
        /// URL will be shown a page saying that the link has been deactivated.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Behavior after the purchase is complete.
        /// </summary>
        [JsonProperty("after_completion")]
        public PaymentLinkAfterCompletionOptions AfterCompletion { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Configuration for automatic tax collection.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public PaymentLinkAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's billing address.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// Configures whether <a href="https://stripe.com/docs/api/checkout/sessions">checkout
        /// sessions</a> created by this payment link create a <a
        /// href="https://stripe.com/docs/api/customers">Customer</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The line items representing what is being sold. Each line item represents an item being
        /// sold. Up to 20 line items are supported.
        /// </summary>
        [JsonProperty("line_items")]
        public List<PaymentLinkLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. Metadata
        /// associated with this Payment Link will automatically be copied to <a
        /// href="https://stripe.com/docs/api/checkout/sessions">checkout sessions</a> created by
        /// this payment link.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The list of payment method types that customers can use. Pass an empty string to enable
        /// automatic payment methods that use your <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">payment method
        /// settings</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's shipping address.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        public PaymentLinkShippingAddressCollectionOptions ShippingAddressCollection { get; set; }
    }
}
