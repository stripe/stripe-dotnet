namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The details associated with the AU BECS Debit payment method for this payment intent.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentIntentPaymentMethodDataAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a Bacs Debit PaymentMethod, this hash contains details about the Bacs Direct
        /// Debit bank account.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentIntentPaymentMethodDataBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a Bancontact PaymentMethod, this hash contains details about the Bancontact
        /// payment method.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodDataBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billing information associated with the payment method for this payment intent.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is an EPS PaymentMethod, this hash contains details about the EPS payment
        /// method.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentIntentPaymentMethodDataEpsOptions Eps { get; set; }

        /// <summary>
        /// The details associated with the FPX payment method for this payment intent.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentIntentPaymentMethodDataFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a Giropay PaymentMethod, this hash contains details about the Giropay payment
        /// method.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodDataGiropayOptions Giropay { get; set; }

        /// <summary>
        /// The details associated with the iDEAL payment method for this payment intent.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentIntentPaymentMethodDataIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is an Interac Present PaymentMethod, this hash contains details about the
        /// Interac Present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentIntentPaymentMethodDataInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful
        /// for storing additional information about the object in a structured format.
        /// Individual keys can be unset by posting an empty value to them.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a P24 PaymentMethod, this hash contains details about the P24 payment method.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodDataP24Options P24 { get; set; }

        /// <summary>
        /// The details associated with the SEPA Debit payment method for this payment intent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodDataSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// The type of payment method for this payment intent.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
