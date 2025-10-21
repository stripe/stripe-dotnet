// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attach_to_self")]
#endif
        public bool? AttachToSelf { get; set; }

        /// <summary>
        /// When you enable this parameter, this SetupIntent accepts payment methods that you enable
        /// in the Dashboard and that are compatible with its other parameters.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_payment_methods")]
#endif
        public SetupIntentAutomaticPaymentMethodsOptions AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// Set to <c>true</c> to attempt to confirm this SetupIntent immediately. This parameter
        /// defaults to <c>false</c>. If a card is the attached payment method, you can provide a
        /// <c>return_url</c> in case further authentication is necessary.
        /// </summary>
        [JsonProperty("confirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirm")]
#endif
        public bool? Confirm { get; set; }

        /// <summary>
        /// ID of the ConfirmationToken used to confirm this SetupIntent.
        ///
        /// If the provided ConfirmationToken contains properties that are also being provided in
        /// this request, such as <c>payment_method</c>, then the values in this request will take
        /// precedence.
        /// </summary>
        [JsonProperty("confirmation_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_token")]
#endif
        public string ConfirmationToken { get; set; }

        /// <summary>
        /// ID of the Customer this SetupIntent belongs to, if one exists.
        ///
        /// If present, the SetupIntent's payment method will be attached to the Customer on
        /// successful setup. Payment methods attached to other Customers cannot be used with this
        /// SetupIntent.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The list of payment method types to exclude from use with this SetupIntent.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>kakao_pay</c>, <c>klarna</c>,
        /// <c>konbini</c>, <c>kr_card</c>, <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>,
        /// <c>naver_pay</c>, <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>,
        /// <c>payco</c>, <c>paynow</c>, <c>paypal</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or
        /// <c>zip</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("excluded_payment_method_types")]
#endif
        public List<string> ExcludedPaymentMethodTypes { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow_directions")]
#endif
        public List<string> FlowDirections { get; set; }

        /// <summary>
        /// This hash contains details about the mandate to create. This parameter can only be used
        /// with <a
        /// href="https://stripe.com/docs/api/setup_intents/create#create_setup_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("mandate_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_data")]
#endif
        public SetupIntentMandateDataOptions MandateData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID created for this SetupIntent.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or saved Source object) to attach to
        /// this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the <a
        /// href="https://stripe.com/docs/api/payment_method_configurations">payment method
        /// configuration</a> to use with this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration")]
#endif
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// When included, this hash creates a PaymentMethod that is set as the <a
        /// href="https://stripe.com/docs/api/setup_intents/object#setup_intent_object-payment_method"><c>payment_method</c></a>
        /// value in the SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public SetupIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (for example, card) that this SetupIntent can use. If
        /// you don't provide this, Stripe will dynamically show relevant payment methods from your
        /// <a href="https://dashboard.stripe.com/settings/payment_methods">payment method
        /// settings</a>. A list of valid payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. To redirect to a mobile application, you
        /// can alternatively supply an application URI scheme. This parameter can only be used with
        /// <a
        /// href="https://stripe.com/docs/api/setup_intents/create#create_setup_intent-confirm"><c>confirm=true</c></a>.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If you populate this hash, this SetupIntent generates a <c>single_use</c> mandate after
        /// successful completion.
        ///
        /// Single-use mandates are only valid for the following payment methods: <c>acss_debit</c>,
        /// <c>alipay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>,
        /// <c>boleto</c>, <c>ideal</c>, <c>link</c>, <c>sepa_debit</c>, and <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("single_use")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("single_use")]
#endif
        public SetupIntentSingleUseOptions SingleUse { get; set; }

        /// <summary>
        /// Indicates how the payment method is intended to be used in the future. If not provided,
        /// this value defaults to <c>off_session</c>.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public string Usage { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_stripe_sdk")]
#endif
        public bool? UseStripeSdk { get; set; }
    }
}
