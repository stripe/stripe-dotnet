namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, new values associated with the card.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }
    }
}
