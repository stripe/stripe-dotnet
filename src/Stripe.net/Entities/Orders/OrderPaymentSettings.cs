// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderPaymentSettings : StripeEntity<OrderPaymentSettings>
    {
        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Indicates whether order has been opted into using <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a> to
        /// manage payment method types.
        /// </summary>
        [JsonProperty("automatic_payment_methods")]
        public OrderPaymentSettingsAutomaticPaymentMethods AutomaticPaymentMethods { get; set; }

        /// <summary>
        /// PaymentMethod-specific configuration to provide to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public OrderPaymentSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of <a href="https://stripe.com/docs/payments/payment-methods/overview">payment
        /// method types</a> to provide to the order's PaymentIntent. Do not include this attribute
        /// if you prefer to manage your payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// One of: <c>acss_debit</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>card</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>,
        /// <c>ideal</c>, <c>klarna</c>, <c>link</c>, <c>oxxo</c>, <c>p24</c>, <c>paypal</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The URL to redirect the customer to after they authenticate their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// For non-card charges, you can use this value as the complete description that appears on
        /// your customers' statements. Must contain at least one letter, maximum 22 characters.
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
        /// Provides configuration for completing a transfer for the order after it is paid.
        /// </summary>
        [JsonProperty("transfer_data")]
        public OrderPaymentSettingsTransferData TransferData { get; set; }
    }
}
