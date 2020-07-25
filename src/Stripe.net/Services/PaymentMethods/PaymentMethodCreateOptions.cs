namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Parameters specific to AU BECS Debit PaymentMethod.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// Parameters specific to BACS Debit PaymentMethod.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// Parameters specific to Bancontact PaymentMethod.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentMethodBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Parameters specific to Card PaymentMethod.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// The customer associated with the PaymentMethod that you are trying to share with a
        /// connected account.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Parameters specific to Eps PaymentMethod.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentMethodEpsOptions Eps { get; set; }

        /// <summary>
        /// Parameters specific to FPX PaymentMethod.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentMethodFpxOptions Fpx { get; set; }

        /// <summary>
        /// Parameters specific to Giropay PaymentMethod.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentMethodGiropayOptions Giropay { get; set; }

        /// <summary>
        /// Parameters specific to iDEAL PaymentMethod.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentMethodIdealOptions Ideal { get; set; }

        /// <summary>
        /// Parameters specific to Interac Present PaymentMethod.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Parameters specific to P24 PaymentMethod.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentMethodP24Options P24 { get; set; }

        /// <summary>
        /// The id of the PaymentMethod that you are trying to share with a Connected account.
        /// This only works with Stripe Connect.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Parameters specific to SEPA Debit PaymentMethod.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
