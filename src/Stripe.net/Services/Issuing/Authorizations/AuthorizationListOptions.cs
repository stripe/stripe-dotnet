namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
