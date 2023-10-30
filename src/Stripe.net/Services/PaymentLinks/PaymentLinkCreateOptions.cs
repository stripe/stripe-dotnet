// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkCreateOptions : BaseOptions, IHasMetadata
    {
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
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. Can only be applied
        /// when there are no line items with recurring prices.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. There must be at least 1 line item with a
        /// recurring price to use this field.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

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
        /// Configure fields to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        public PaymentLinkConsentCollectionOptions ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a> and supported by each line item's price.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 2 fields
        /// are supported.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<PaymentLinkCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Display additional text for your customers using custom text.
        /// </summary>
        [JsonProperty("custom_text")]
        public PaymentLinkCustomTextOptions CustomText { get; set; }

        /// <summary>
        /// Configures whether <a href="https://stripe.com/docs/api/checkout/sessions">checkout
        /// sessions</a> created by this payment link create a <a
        /// href="https://stripe.com/docs/api/customers">Customer</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// Generate a post-purchase Invoice for one-time payments.
        /// </summary>
        [JsonProperty("invoice_creation")]
        public PaymentLinkInvoiceCreationOptions InvoiceCreation { get; set; }

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
        /// The account on behalf of which to charge.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to PaymentIntent creation for Checkout Sessions in
        /// <c>payment</c> mode.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        public PaymentLinkPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect a payment method. When set to
        /// <c>if_required</c>, Checkout will not collect a payment method when the total due for
        /// the session is 0.This may occur if the Checkout Session includes a free trial or a
        /// discount.
        ///
        /// Can only be set in <c>subscription</c> mode.
        ///
        /// If you'd like information on how to collect a payment method outside of Checkout, read
        /// the guide on <a href="https://stripe.com/docs/payments/checkout/free-trials">configuring
        /// subscriptions with a free trial</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// The list of payment method types that customers can use. If no value is passed, Stripe
        /// will dynamically show relevant payment methods from your <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">payment method settings</a>
        /// (20+ payment methods <a
        /// href="https://stripe.com/docs/payments/payment-methods/integration-options#payment-method-product-support">supported</a>).
        /// One of: <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>, <c>au_becs_debit</c>,
        /// <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>oxxo</c>, <c>p24</c>, <c>paynow</c>,
        /// <c>paypal</c>, <c>pix</c>, <c>promptpay</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Controls phone number collection settings during checkout.
        ///
        /// We recommend that you review your privacy policy and check with your legal contacts.
        /// </summary>
        [JsonProperty("phone_number_collection")]
        public PaymentLinkPhoneNumberCollectionOptions PhoneNumberCollection { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's shipping address.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        public PaymentLinkShippingAddressCollectionOptions ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options to apply to <a
        /// href="https://stripe.com/docs/api/checkout/sessions">checkout sessions</a> created by
        /// this payment link.
        /// </summary>
        [JsonProperty("shipping_options")]
        public List<PaymentLinkShippingOptionOptions> ShippingOptions { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed in order to customize relevant text on
        /// the page, such as the submit button. Changing this value will also affect the hostname
        /// in the <a
        /// href="https://stripe.com/docs/api/payment_links/payment_links/object#url">url</a>
        /// property (example: <c>donate.stripe.com</c>).
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, or <c>pay</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// When creating a subscription, the specified configuration data will be used. There must
        /// be at least one line item with a recurring price to use <c>subscription_data</c>.
        /// </summary>
        [JsonProperty("subscription_data")]
        public PaymentLinkSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// Controls tax ID collection during checkout.
        /// </summary>
        [JsonProperty("tax_id_collection")]
        public PaymentLinkTaxIdCollectionOptions TaxIdCollection { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentLinkTransferDataOptions TransferData { get; set; }
    }
}
