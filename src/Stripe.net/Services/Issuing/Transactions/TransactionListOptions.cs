namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
    }
}
