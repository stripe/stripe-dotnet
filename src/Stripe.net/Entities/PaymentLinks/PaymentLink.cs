// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A payment link is a shareable URL that will take your customers to a hosted payment
    /// page. A payment link can be shared and used multiple times.
    ///
    /// When a customer opens a payment link it will open a new <a
    /// href="https://stripe.com/docs/api/checkout/sessions">checkout session</a> to render the
    /// payment page. You can use <a
    /// href="https://stripe.com/docs/api/events/types#event_types-checkout.session.completed">checkout
    /// session events</a> to track payments through payment links.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payment-links">Payment Links API</a>.
    /// </summary>
    public class PaymentLink : StripeEntity<PaymentLink>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the payment link's <c>url</c> is active. If <c>false</c>, customers visiting the
        /// URL will be shown a page saying that the link has been deactivated.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("after_completion")]
        public PaymentLinkAfterCompletion AfterCompletion { get; set; }

        /// <summary>
        /// Whether user redeemable promotion codes are enabled.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool AllowPromotionCodes { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// The ID of the Connect application that created the Payment Link.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Connect application that created the Payment Link.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// This represents the percentage of the subscription invoice total that will be
        /// transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("automatic_tax")]
        public PaymentLinkAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's billing address.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// When set, provides configuration to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        public PaymentLinkConsentCollection ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 2 fields
        /// are supported.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<PaymentLinkCustomField> CustomFields { get; set; }

        [JsonProperty("custom_text")]
        public PaymentLinkCustomText CustomText { get; set; }

        /// <summary>
        /// Configuration for Customer creation during checkout.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// Configuration for creating invoice for payment mode payment links.
        /// </summary>
        [JsonProperty("invoice_creation")]
        public PaymentLinkInvoiceCreation InvoiceCreation { get; set; }

        /// <summary>
        /// The line items representing what is being sold.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
        /// documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// Indicates the parameters to be passed to PaymentIntent creation during checkout.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        public PaymentLinkPaymentIntentData PaymentIntentData { get; set; }

        /// <summary>
        /// Configuration for collecting a payment method during checkout.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// The list of payment method types that customers can use. When <c>null</c>, Stripe will
        /// dynamically show relevant payment methods you've enabled in your <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">payment method
        /// settings</a>.
        /// One of: <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>, <c>au_becs_debit</c>,
        /// <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>oxxo</c>, <c>p24</c>, <c>paynow</c>,
        /// <c>paypal</c>, <c>pix</c>, <c>promptpay</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("phone_number_collection")]
        public PaymentLinkPhoneNumberCollection PhoneNumberCollection { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's shipping address.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        public PaymentLinkShippingAddressCollection ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options applied to the session.
        /// </summary>
        [JsonProperty("shipping_options")]
        public List<PaymentLinkShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// Indicates the type of transaction being performed which customizes relevant text on the
        /// page, such as the submit button.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, or <c>pay</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// When creating a subscription, the specified configuration data will be used. There must
        /// be at least one line item with a recurring price to use <c>subscription_data</c>.
        /// </summary>
        [JsonProperty("subscription_data")]
        public PaymentLinkSubscriptionData SubscriptionData { get; set; }

        [JsonProperty("tax_id_collection")]
        public PaymentLinkTaxIdCollection TaxIdCollection { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to.
        /// </summary>
        [JsonProperty("transfer_data")]
        public PaymentLinkTransferData TransferData { get; set; }

        /// <summary>
        /// The public URL that can be shared with customers.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
