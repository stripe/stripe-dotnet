namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount intended to be collected by this PaymentIntent. A positive integer representing
        /// how much to charge in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum
        /// amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be applied to the payment and
        /// transferred to the application owner's Stripe account. Must be greater than zero when
        /// provided. For more information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        ///
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If present in combination with <a
        /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>,
        /// this PaymentIntent's payment method will be attached to the Customer after the
        /// PaymentIntent has been confirmed and any required actions from the user are complete.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or <a
        /// href="https://stripe.com/docs/payments/payment-methods#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If provided, this hash will be used to create a PaymentMethod. The new PaymentMethod
        /// will appear in the <a
        /// href="https://stripe.com/docs/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
        /// property on the PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this PaymentIntent is allowed to use.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to. If
        /// <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent
        /// regardless of your <a href="https://dashboard.stripe.com/account/emails">email
        /// settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// If the PaymentIntent has a <c>payment_method</c> and a <c>customer</c> or if you're
        /// attaching a payment method to the PaymentIntent in this request, you can pass
        /// <c>save_payment_method=true</c> to save the payment method to the customer immediately.
        ///
        /// If the payment method is already saved to a customer, this parameter does nothing. If
        /// this type of payment method cannot be saved to a customer, the request will error.
        ///
        /// Saving a payment method using this parameter is <em>not recommended</em> because it will
        /// save the payment method even if it cannot be charged (e.g. the user made a typo). To
        /// ensure that only payment methods which are likely to be chargeable are saved to a
        /// customer, use the
        /// (setup_future_usage)[#payment_intents/object#payment_intent_object-setup_future_usage]
        /// property, which saves the payment method after the PaymentIntent has been confirmed and
        /// all required actions by the customer are complete.
        /// </summary>
        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        ///
        /// If <c>setup_future_usage</c> is already set and you are performing a request using a
        /// publishable key, you may only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// This is a legacy field that will be removed in the future. It is the ID of the Source
        /// object to attach to this PaymentIntent. Please use the <c>payment_method</c> field
        /// instead, which also supports Cards and <a
        /// href="https://stripe.com/docs/payments/payment-methods#compatibility">compatible
        /// Source</a> objects.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// For non-card charges, you can use this value as the complete description that appears on
        /// your customers’ statements. Must contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The parameters used to automatically create a Transfer when the payment succeeds. For
        /// more information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. <c>transfer_group</c>
        /// may only be provided if it has not been set. See the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
