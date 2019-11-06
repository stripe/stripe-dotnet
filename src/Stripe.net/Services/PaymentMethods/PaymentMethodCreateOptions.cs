namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, raw card details. You must meet the requirements
        /// for PCI compliance. We strongly recommend using Stripe.js instead of interacting with
        /// this API directly.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardCreateOptions Card { get; set; }

        /// <summary>
        /// The customer associated with the PaymentMethod that you are trying to share with a
        /// connected account.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// This is a <c>FPX</c> PaymentMethod available in Malaysia.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentMethodFpxCreateOptions Fpx { get; set; }

        /// <summary>
        /// If this is an <c>ideal</c> PaymentMethod, this contains details about the iDEAL payment
        /// method.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentMethodIdealCreateOptions Ideal { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The id of the PaymentMethod that you are trying to share with a Connected account.
        /// This only works with Stripe Connect.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentMethod, this contains details about the SEPA debit
        /// bank account.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitCreateOptions SepaDebit { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
