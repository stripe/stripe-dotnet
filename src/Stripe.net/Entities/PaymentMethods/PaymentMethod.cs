// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// PaymentMethod objects represent your customer's payment instruments. You can use them
    /// with <a href="https://stripe.com/docs/payments/payment-intents">PaymentIntents</a> to
    /// collect payments or save them to Customer objects to store instrument details for future
    /// payments.
    ///
    /// Related guides: <a href="https://stripe.com/docs/payments/payment-methods">Payment
    /// Methods</a> and <a href="https://stripe.com/docs/payments/more-payment-scenarios">More
    /// Payment Scenarios</a>.
    /// </summary>
    public class PaymentMethod : StripeEntity<PaymentMethod>, IHasId, IHasMetadata, IHasObject
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

        [JsonProperty("acss_debit")]
        public PaymentMethodAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        public PaymentMethodAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public PaymentMethodAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public PaymentMethodAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        public PaymentMethodBlik Blik { get; set; }

        [JsonProperty("boleto")]
        public PaymentMethodBoleto Boleto { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        public PaymentMethodCashapp Cashapp { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_balance")]
        public PaymentMethodCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public PaymentMethodEps Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public PaymentMethodGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        [JsonProperty("klarna")]
        public PaymentMethodKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public PaymentMethodKonbini Konbini { get; set; }

        [JsonProperty("link")]
        public PaymentMethodLink Link { get; set; }

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

        [JsonProperty("mobilepay")]
        public PaymentMethodMobilepay Mobilepay { get; set; }

        [JsonProperty("oxxo")]
        public PaymentMethodOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public PaymentMethodP24 P24 { get; set; }

        [JsonProperty("paynow")]
        public PaymentMethodPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public PaymentMethodPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        public PaymentMethodPix Pix { get; set; }

        [JsonProperty("promptpay")]
        public PaymentMethodPromptpay Promptpay { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
        public PaymentMethodRadarOptions RadarOptions { get; set; }

        [JsonProperty("revolut_pay")]
        public PaymentMethodRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public PaymentMethodSofort Sofort { get; set; }

        [JsonProperty("swish")]
        public PaymentMethodSwish Swish { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>card</c>, <c>card_present</c>, <c>cashapp</c>, <c>customer_balance</c>, <c>eps</c>,
        /// <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>link</c>, <c>mobilepay</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>pix</c>, <c>promptpay</c>, <c>revolut_pay</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, <c>swish</c>, <c>us_bank_account</c>,
        /// <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public PaymentMethodUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        public PaymentMethodWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        public PaymentMethodZip Zip { get; set; }
    }
}
