namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, this hash contains the user's card details.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }
    }
}
