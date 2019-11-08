namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderCreateOptions : CardholderSharedOptions
    {
        /// <summary>
        /// The type of cardholder. Possible values are <c>individual</c> or <c>business_entity</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
