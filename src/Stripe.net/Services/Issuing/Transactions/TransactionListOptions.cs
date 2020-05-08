namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }
    }
}
