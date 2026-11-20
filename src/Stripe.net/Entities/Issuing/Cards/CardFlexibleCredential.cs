// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardFlexibleCredential : StripeEntity<CardFlexibleCredential>
    {
        /// <summary>
        /// Details about the secondary credentials for this card.
        /// </summary>
        [JsonProperty("secondary_credentials")]
        [STJS.JsonPropertyName("secondary_credentials")]
        public List<CardFlexibleCredentialSecondaryCredential> SecondaryCredentials { get; set; }
    }
}
