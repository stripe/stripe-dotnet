namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsFpx : StripeEntity<ChargePaymentMethodDetailsFpx>
    {
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
