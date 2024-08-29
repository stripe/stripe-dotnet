// File generated from our OpenAPI spec
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
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. The amount of the
        /// application fee collected will be capped at the total payment amount. For more
        /// information, see the PaymentIntents <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, <c>automatic_async</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

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
        /// If <a
        /// href="https://stripe.com/docs/api#payment_intent_object-setup_future_usage">setup_future_usage</a>
        /// is set and this PaymentIntent's payment method is not <c>card_present</c>, then the
        /// payment method attaches to the Customer after the PaymentIntent has been confirmed and
        /// any required actions from the user are complete. If the payment method is
        /// <c>card_present</c> and isn't a digital wallet, then a <a
        /// href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card is created and attached to the Customer instead.
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
        /// href="https://stripe.com/docs/payments/payment-methods/transitioning#compatibility">compatible
        /// Source</a> object) to attach to this PaymentIntent. To unset this field to null, pass in
        /// an empty string.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The ID of the payment method configuration to use with this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

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
        /// The list of payment method types (for example, card) that this PaymentIntent can use.
        /// Use <c>automatic_payment_methods</c> to manage payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
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
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a
        /// href="https://stripe.com/payments/save-during-payment">attach the payment method</a> to
        /// the Customer after the PaymentIntent is confirmed and the customer completes any
        /// required actions. If you don't provide a Customer, you can still <a
        /// href="https://stripe.com/api/payment_methods/attach">attach</a> the payment method to a
        /// Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates
        /// and attaches a <a
        /// href="https://stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply
        /// with regional legislation and network rules, such as <a
        /// href="https://stripe.com/strong-customer-authentication">SCA</a>.
        ///
        /// If you've already set <c>setup_future_usage</c> and you're performing a request using a
        /// publishable key, you can only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// Text that appears on the customer's statement as the statement descriptor for a non-card
        /// charge. This value overrides the account's default statement descriptor. For information
        /// about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// Setting this value for a card charge returns an error. For card charges, set the <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#dynamic">statement_descriptor_suffix</a>
        /// instead.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Use this parameter to automatically create a Transfer when the payment succeeds. Learn
        /// more about the <a href="https://stripe.com/docs/payments/connected-accounts">use case
        /// for connected accounts</a>.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. You can only provide
        /// <c>transfer_group</c> if it hasn't been set. Learn more about the <a
        /// href="https://stripe.com/docs/payments/connected-accounts">use case for connected
        /// accounts</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
