namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataOptions : INestedOptions
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardCreateOptions Card { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpxCreateOptions Fpx { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdealCreateOptions Ideal { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitCreateOptions SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
