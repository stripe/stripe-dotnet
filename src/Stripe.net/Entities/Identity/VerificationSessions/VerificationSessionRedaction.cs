// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionRedaction : StripeEntity<VerificationSessionRedaction>
    {
        /// <summary>
        /// Indicates whether this object and its related objects have been redacted or not.
        /// One of: <c>processing</c>, or <c>redacted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
