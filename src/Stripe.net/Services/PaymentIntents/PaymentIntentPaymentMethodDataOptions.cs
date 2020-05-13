namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// The details associated with the AU BECS Debit payment method for this payment intent.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        /// <summary>
        /// Billing information associated with the payment method for this payment intent.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The details associated with the card payment method for this payment intent.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardCreateOptions Card { get; set; }

        /// <summary>
        /// The details associated with the FPX payment method for this payment intent.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentMethodFpxCreateOptions Fpx { get; set; }

        /// <summary>
        /// The details associated with the iDEAL payment method for this payment intent.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentMethodIdealCreateOptions Ideal { get; set; }

        /// <summary>
        /// The details associated with the SEPA Debit payment method for this payment intent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitCreateOptions SepaDebit { get; set; }

        /// <summary>
        /// The type of payment method for this payment intent.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
