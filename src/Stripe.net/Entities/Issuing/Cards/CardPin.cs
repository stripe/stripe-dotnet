namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardPin : StripeEntity<CardPin>
    {
        /// <summary>
        /// The status of the pin. One of <c>blocked</c> or <c>active</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
