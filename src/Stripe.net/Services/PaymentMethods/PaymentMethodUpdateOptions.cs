namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitUpdateOptions AuBecsDebit { get; set; }

        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardUpdateOptions Card { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitUpdateOptions SepaDebit { get; set; }
    }
}
