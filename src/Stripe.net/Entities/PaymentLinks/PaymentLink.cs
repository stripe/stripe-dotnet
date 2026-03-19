// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A payment link is a shareable URL that will take your customers to a hosted payment
    /// page. A payment link can be shared and used multiple times.
    ///
    /// When a customer opens a payment link it will open a new <a
    /// href="https://docs.stripe.com/api/checkout/sessions">checkout session</a> to render the
    /// payment page. You can use <a
    /// href="https://docs.stripe.com/api/events/types#event_types-checkout.session.completed">checkout
    /// session events</a> to track payments through payment links.
    ///
    /// Related guide: <a href="https://docs.stripe.com/payment-links">Payment Links API</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLink : StripeEntity<PaymentLink>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the payment link's <c>url</c> is active. If <c>false</c>, customers visiting the
        /// URL will be shown a page saying that the link has been deactivated.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonProperty("after_completion")]
        [STJS.JsonPropertyName("after_completion")]
        public PaymentLinkAfterCompletion AfterCompletion { get; set; }

        /// <summary>
        /// Whether user redeemable promotion codes are enabled.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        [STJS.JsonPropertyName("allow_promotion_codes")]
        public bool AllowPromotionCodes { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// The ID of the Connect application that created the Payment Link.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// This represents the percentage of the subscription invoice total that will be
        /// transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        [STJS.JsonPropertyName("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public PaymentLinkAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's billing address. Defaults to <c>auto</c>.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        [STJS.JsonPropertyName("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// When set, provides configuration to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        [STJS.JsonPropertyName("consent_collection")]
        public PaymentLinkConsentCollection ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 3 fields
        /// are supported. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public List<PaymentLinkCustomField> CustomFields { get; set; }

        [JsonProperty("custom_text")]
        [STJS.JsonPropertyName("custom_text")]
        public PaymentLinkCustomText CustomText { get; set; }

        /// <summary>
        /// Configuration for Customer creation during checkout.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        [STJS.JsonPropertyName("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The custom message to be displayed to a customer when a payment link is no longer
        /// active.
        /// </summary>
        [JsonProperty("inactive_message")]
        [STJS.JsonPropertyName("inactive_message")]
        public string InactiveMessage { get; set; }

        /// <summary>
        /// Configuration for creating invoice for payment mode payment links.
        /// </summary>
        [JsonProperty("invoice_creation")]
        [STJS.JsonPropertyName("invoice_creation")]
        public PaymentLinkInvoiceCreation InvoiceCreation { get; set; }

        /// <summary>
        /// The line items representing what is being sold.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name_collection")]
        [STJS.JsonPropertyName("name_collection")]
        public PaymentLinkNameCollection NameCollection { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// The optional items presented to the customer at checkout.
        /// </summary>
        [JsonProperty("optional_items")]
        [STJS.JsonPropertyName("optional_items")]
        public List<PaymentLinkOptionalItem> OptionalItems { get; set; }

        /// <summary>
        /// Indicates the parameters to be passed to PaymentIntent creation during checkout.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        [STJS.JsonPropertyName("payment_intent_data")]
        public PaymentLinkPaymentIntentData PaymentIntentData { get; set; }

        /// <summary>
        /// Configuration for collecting a payment method during checkout. Defaults to
        /// <c>always</c>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        [STJS.JsonPropertyName("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// The list of payment method types that customers can use. When <c>null</c>, Stripe will
        /// dynamically show relevant payment methods you've enabled in your <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">payment method
        /// settings</a>.
        /// One of: <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>, <c>alma</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>billie</c>, <c>blik</c>,
        /// <c>boleto</c>, <c>card</c>, <c>cashapp</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>,
        /// <c>gopay</c>, <c>grabpay</c>, <c>ideal</c>, <c>klarna</c>, <c>konbini</c>, <c>link</c>,
        /// <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>pay_by_bank</c>, <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>,
        /// <c>pix</c>, <c>promptpay</c>, <c>qris</c>, <c>rechnung</c>, <c>satispay</c>,
        /// <c>sepa_debit</c>, <c>shopeepay</c>, <c>sofort</c>, <c>swish</c>, <c>twint</c>,
        /// <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        [STJS.JsonPropertyName("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("phone_number_collection")]
        [STJS.JsonPropertyName("phone_number_collection")]
        public PaymentLinkPhoneNumberCollection PhoneNumberCollection { get; set; }

        /// <summary>
        /// Settings that restrict the usage of a payment link.
        /// </summary>
        [JsonProperty("restrictions")]
        [STJS.JsonPropertyName("restrictions")]
        public PaymentLinkRestrictions Restrictions { get; set; }

        /// <summary>
        /// Configuration for collecting the customer's shipping address.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        [STJS.JsonPropertyName("shipping_address_collection")]
        public PaymentLinkShippingAddressCollection ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options applied to the session.
        /// </summary>
        [JsonProperty("shipping_options")]
        [STJS.JsonPropertyName("shipping_options")]
        public List<PaymentLinkShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// Indicates the type of transaction being performed which customizes relevant text on the
        /// page, such as the submit button.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, <c>pay</c>, or <c>subscribe</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        [STJS.JsonPropertyName("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// When creating a subscription, the specified configuration data will be used. There must
        /// be at least one line item with a recurring price to use <c>subscription_data</c>.
        /// </summary>
        [JsonProperty("subscription_data")]
        [STJS.JsonPropertyName("subscription_data")]
        public PaymentLinkSubscriptionData SubscriptionData { get; set; }

        [JsonProperty("tax_id_collection")]
        [STJS.JsonPropertyName("tax_id_collection")]
        public PaymentLinkTaxIdCollection TaxIdCollection { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public PaymentLinkTransferData TransferData { get; set; }

        /// <summary>
        /// The public URL that can be shared with customers.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
