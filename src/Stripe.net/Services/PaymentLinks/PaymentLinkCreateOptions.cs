// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Behavior after the purchase is complete.
        /// </summary>
        [JsonProperty("after_completion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after_completion")]
#endif
        public PaymentLinkAfterCompletionOptions AfterCompletion { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_promotion_codes")]
#endif
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. Can only be applied
        /// when there are no line items with recurring prices.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. There must be at least 1 line item with a
        /// recurring price to use this field.
        /// </summary>
        [JsonProperty("application_fee_percent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_percent")]
#endif
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Configuration for automatic tax collection.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public PaymentLinkAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's billing address. Defaults to <c>auto</c>.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_address_collection")]
#endif
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// Configure fields to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consent_collection")]
#endif
        public PaymentLinkConsentCollectionOptions ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a> and supported by each line item's price.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 3 fields
        /// are supported.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<PaymentLinkCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Display additional text for your customers using custom text.
        /// </summary>
        [JsonProperty("custom_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_text")]
#endif
        public PaymentLinkCustomTextOptions CustomText { get; set; }

        /// <summary>
        /// Configures whether <a href="https://stripe.com/docs/api/checkout/sessions">checkout
        /// sessions</a> created by this payment link create a <a
        /// href="https://stripe.com/docs/api/customers">Customer</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_creation")]
#endif
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The custom message to be displayed to a customer when a payment link is no longer
        /// active.
        /// </summary>
        [JsonProperty("inactive_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inactive_message")]
#endif
        public string InactiveMessage { get; set; }

        /// <summary>
        /// Generate a post-purchase Invoice for one-time payments.
        /// </summary>
        [JsonProperty("invoice_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_creation")]
#endif
        public PaymentLinkInvoiceCreationOptions InvoiceCreation { get; set; }

        /// <summary>
        /// The line items representing what is being sold. Each line item represents an item being
        /// sold. Up to 20 line items are supported.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account on behalf of which to charge.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to PaymentIntent creation for Checkout Sessions in
        /// <c>payment</c> mode.
        /// </summary>
        [JsonProperty("payment_intent_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent_data")]
#endif
        public PaymentLinkPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect a payment method. When set to
        /// <c>if_required</c>, Checkout will not collect a payment method when the total due for
        /// the session is 0.This may occur if the Checkout Session includes a free trial or a
        /// discount.
        ///
        /// Can only be set in <c>subscription</c> mode. Defaults to <c>always</c>.
        ///
        /// If you'd like information on how to collect a payment method outside of Checkout, read
        /// the guide on <a href="https://stripe.com/docs/payments/checkout/free-trials">configuring
        /// subscriptions with a free trial</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_collection")]
#endif
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// The list of payment method types that customers can use. If no value is passed, Stripe
        /// will dynamically show relevant payment methods from your <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">payment method settings</a>
        /// (20+ payment methods <a
        /// href="https://stripe.com/docs/payments/payment-methods/integration-options#payment-method-product-support">supported</a>).
        /// One of: <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>, <c>alma</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>card</c>, <c>cashapp</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>,
        /// <c>ideal</c>, <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>mobilepay</c>,
        /// <c>multibanco</c>, <c>oxxo</c>, <c>p24</c>, <c>paynow</c>, <c>paypal</c>, <c>pix</c>,
        /// <c>promptpay</c>, <c>sepa_debit</c>, <c>sofort</c>, <c>swish</c>, <c>twint</c>,
        /// <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Controls phone number collection settings during checkout.
        ///
        /// We recommend that you review your privacy policy and check with your legal contacts.
        /// </summary>
        [JsonProperty("phone_number_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number_collection")]
#endif
        public PaymentLinkPhoneNumberCollectionOptions PhoneNumberCollection { get; set; }

        /// <summary>
        /// Settings that restrict the usage of a payment link.
        /// </summary>
        [JsonProperty("restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restrictions")]
#endif
        public PaymentLinkRestrictionsOptions Restrictions { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's shipping address.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address_collection")]
#endif
        public PaymentLinkShippingAddressCollectionOptions ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options to apply to <a
        /// href="https://stripe.com/docs/api/checkout/sessions">checkout sessions</a> created by
        /// this payment link.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<PaymentLinkShippingOptionOptions> ShippingOptions { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed in order to customize relevant text on
        /// the page, such as the submit button. Changing this value will also affect the hostname
        /// in the <a
        /// href="https://stripe.com/docs/api/payment_links/payment_links/object#url">url</a>
        /// property (example: <c>donate.stripe.com</c>).
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, <c>pay</c>, or <c>subscribe</c>.
        /// </summary>
        [JsonProperty("submit_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submit_type")]
#endif
        public string SubmitType { get; set; }

        /// <summary>
        /// When creating a subscription, the specified configuration data will be used. There must
        /// be at least one line item with a recurring price to use <c>subscription_data</c>.
        /// </summary>
        [JsonProperty("subscription_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_data")]
#endif
        public PaymentLinkSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// Controls tax ID collection during checkout.
        /// </summary>
        [JsonProperty("tax_id_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_collection")]
#endif
        public PaymentLinkTaxIdCollectionOptions TaxIdCollection { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public PaymentLinkTransferDataOptions TransferData { get; set; }
    }
}
