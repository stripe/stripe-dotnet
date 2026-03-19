// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionRelatedPerson : StripeEntity<VerificationSessionRelatedPerson>
    {
        /// <summary>
        /// Token referencing the associated Account of the related Person resource.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Token referencing the related Person resource.
        /// </summary>
        [JsonProperty("person")]
        [STJS.JsonPropertyName("person")]
        public string Person { get; set; }
    }
}
