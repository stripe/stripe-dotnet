namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// If this is an <c>Alipay</c> PaymentMethod, this hash contains details about the Alipay
        /// payment method.
        /// </summary>
        [JsonProperty("alipay")]
        public PaymentMethodAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is an <c>au_becs_debit</c> PaymentMethod, this hash contains details about the
        /// bank account.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this hash contains details about the Bacs
        /// Direct Debit bank account.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this hash contains details about the
        /// Bancontact payment method.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentMethodBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// The <c>Customer</c> to whom the original PaymentMethod is attached.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// If this is an <c>eps</c> PaymentMethod, this hash contains details about the EPS payment
        /// method.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentMethodEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is an <c>fpx</c> PaymentMethod, this hash contains details about the FPX payment
        /// method.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentMethodFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this hash contains details about the Giropay
        /// payment method.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentMethodGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is an <c>ideal</c> PaymentMethod, this hash contains details about the iDEAL
        /// payment method.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentMethodIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is an <c>interac_present</c> PaymentMethod, this hash contains details about the
        /// Interac Present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this hash contains details about the P24 payment
        /// method.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentMethodP24Options P24 { get; set; }

        /// <summary>
        /// The PaymentMethod to share.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentMethod, this hash contains details about the SEPA
        /// debit bank account.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>alipay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>p24</c>, or <c>sepa_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
