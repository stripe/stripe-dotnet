namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }
    }
}
