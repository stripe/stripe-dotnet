namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Set to <c>true</c> to attempt to confirm this SetupIntent immediately. This parameter
        /// defaults to <c>false</c>. If the payment method attached is a card, a <c>ReturnUrl</c>
        /// may be provided in case additional authentication is required.
        /// </summary>
        [JsonProperty("confirm")]
        public bool? Confirm { get; set; }

        /// <summary>
        /// <para>
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        /// </para>
        /// <para>
        /// If present, payment methods used with this SetupIntent can only be attached to this
        /// Customer, and payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
        /// </para>
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users. This
        /// can be unset by updating the value to null and then saving.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for
        /// storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID for which this SetupIntent is created.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, BankAccount, or saved Source object) to
        /// attach to this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types that this SetupIntent is allowed to set up. If this is
        /// not provided, defaults to card.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate on the payment
        /// method’s app or site. If you’d prefer to redirect to a mobile application, you can
        /// alternatively supply an application URI scheme. This parameter is only used for cards
        /// and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates how the payment method is intended to be used in the future. Use
        /// <c>on_session</c> if you intend to only reuse the payment method when the customer is in
        /// your checkout flow. Use <c>off_session</c> if your customer may or may not be in your
        /// checkout flow. If not provided, this value defaults to <c>off_session</c>.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
