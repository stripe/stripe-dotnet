// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SetupIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// If present, the SetupIntent's payment method will be attached to the in-context Stripe
        /// Account.
        ///
        /// It can only be used for this Stripe Account’s own money movement flows like
        /// InboundTransfer and OutboundTransfers. It cannot be set to true when setting up a
        /// PaymentMethod for a Customer, and defaults to false when attaching a PaymentMethod to a
        /// Customer.
        /// </summary>
        [JsonProperty("attach_to_self")]
        public bool? AttachToSelf { get; set; }

        /// <summary>
        /// When you enable this parameter, this SetupIntent accepts payment methods that you enable
        /// in the Dashboard and that are compatible with its other parameters.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
        public SetupIntentAutomaticPaymentMethodsOptions AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Set to <c>true</c> to attempt to confirm this SetupIntent immediately. This parameter
        /// defaults to <c>false</c>. If a card is the attached payment method, you can provide a
        /// <c>return_url</c> in case further authentication is necessary.
        /// </summary>
        [JsonProperty("confirm")]
        public bool? Confirm { get; set; }

        /// <summary>
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Indicates the directions of money movement for which this payment method is intended to
        /// be used.
        ///
        /// Include <c>inbound</c> if you intend to use the payment method as the origin to pull
        /// funds from. Include <c>outbound</c> if you intend to use the payment method as the
        /// destination to send funds to. You can include both if you intend to use the payment
        /// method for both purposes.
        /// One of: <c>inbound</c>, or <c>outbound</c>.
        /// </summary>
        [JsonProperty("flow_directions")]
        public List<string> FlowDirections { get; set; }

        /// <summary>
        /// This hash contains details about the mandate to create. This parameter can only be used
        /// with <a
        /// href="https://stripe.com/docs/api/setup_intents/create#create_setup_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate_data")]
        public SetupIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID created for this SetupIntent.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or saved Source object) to attach to
        /// this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the payment method configuration to use with this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// When included, this hash creates a PaymentMethod that is set as the <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-payment_method"><c>payment_method</c></a>
        /// value in the SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        public SetupIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (for example, card) that this SetupIntent can use. If
        /// you don't provide this, it defaults to ["card"].
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. To redirect to a mobile application, you
        /// can alternatively supply an application URI scheme. This parameter can only be used with
        /// <a
        /// href="https://stripe.com/docs/api/setup_intents/create#create_setup_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If you populate this hash, this SetupIntent generates a <c>single_use</c> mandate after
        /// successful completion.
        /// </summary>
        [JsonProperty("single_use")]
        public SetupIntentSingleUseOptions SingleUse { get; set; }

        /// <summary>
        /// Indicates how the payment method is intended to be used in the future. If not provided,
        /// this value defaults to <c>off_session</c>.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
