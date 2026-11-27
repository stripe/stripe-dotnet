// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardFlexibleCredentialSecondaryCredential : StripeEntity<CardFlexibleCredentialSecondaryCredential>
    {
        /// <summary>
        /// The funding source that this credential can support.
        /// One of: <c>credit</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }
    }
}
