namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing how much to charge in the smallest currency unit (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be applied to the payment and
        /// transferred to the application owner’s Stripe account. For more information, see the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">use
        /// case for connected accounts</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// One of <c>automatic</c> (default) or <c>manual</c>.
        /// When the capture method is <c>automatic</c>, Stripe automatically captures funds when
        /// the customer authorizes the payment.
        /// Change the capture method to <c>manual</c> if you wish to <a href="https://stripe.com/docs/payments/payment-intents/quickstart#automatic-confirmation-flow">
        /// separate authorization and capture</a> for payment methods that support this.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Set to <c>true</c> to attempt to confirm this PaymentIntent immediately. This parameter
        /// defaults to <c>false</c>. If the payment method attached is a card, a return_url may be provided in case additional authentication is required.
        /// </summary>
        [JsonProperty("confirm")]
        public bool? Confirm { get; set; }

        /// <summary>
        /// One of <c>automatic</c> (default) or <c>manual</c>.
        /// When the confirmation method is <c>automatic</c>, a PaymentIntent can be confirmed
        /// using a publishable key. After next actions are handled, no additional confirmation is
        /// required to complete the payment.
        /// When the confirmation method is <c>manual</c>, all payment attempts must be made using
        /// a secret key. The PaymentIntent returns to the requires_confirmation state after
        /// handling next_actions, and requires your server to initiate each payment attempt with
        /// an explicit confirmation.
        /// </summary>
        [JsonProperty("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// ID of the Customer this PaymentIntent belongs to, if one exists.
        /// If present, payment methods used with this PaymentIntent can only be attached to this
        /// Customer, and payment methods attached to other Customers cannot be used with this
        /// PaymentIntent.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer is not in your checkout flow during
        /// this payment attempt, and therefore is unable to authenticate. This parameter is
        /// intended for scenarios where you collect card details and <a href="https://stripe.com/docs/payments/cards/reusing-cards">
        /// charge them later</a>.
        /// </summary>
        [JsonProperty("off_session")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<bool?, string> OffSession { get; set; }

        /// <summary>
        /// The Stripe account ID for which these funds are intended. For details, see the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, BankAccount, or saved Source object) to
        /// attach to this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

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
        /// Email address that the receipt for the resulting payment will be sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If the PaymentIntent has a payment_method and a customer or if you’re attaching a
        /// payment method to the PaymentIntent in this request, you can pass this as <c>true</c>
        /// to save the payment method to the customer. Defaults to <c>false</c>.
        /// If the payment method is already saved to a customer, this does nothing. If this type
        /// of payment method cannot be saved to a customer, the request will error.
        /// </summary>
        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent’s payment
        /// method.
        /// If present, the payment method used with this PaymentIntent can be attached to a
        /// Customer, even after the transaction completes.
        /// Use <c>on_session</c> if you intend to only reuse the payment method when your customer
        /// is present in your checkout flow. Use <c>off_session</c> if your customer may or may
        /// not be in your checkout flow.
        /// Stripe uses this to dynamically optimize your payment flow and comply with regional
        /// legislation and network rules. For example, if your customer is impacted by SCA, using
        /// <c>off_session</c> will ensure that they are authenticated while processing this
        /// PaymentIntent. You will then be able to make later off-session payments for this
        /// customer.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// ID of the Source to use with this PaymentIntent. Prefer using <see cref="PaymentMethod"/>.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Extra information about a PaymentIntent. This will appear on your customer’s statement
        /// when this PaymentIntent succeeds in creating a charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer when the payment is finalized.
        /// See the PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies the resulting payment as part of a group. See the
        /// PaymentIntents <a href="https://stripe.com/docs/payments/payment-intents/use-cases#connected-accounts">
        /// use case for connected accounts</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
