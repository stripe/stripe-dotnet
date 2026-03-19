// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSessionOptionsPhone : StripeEntity<VerificationSessionOptionsPhone>
    {
        /// <summary>
        /// Request one time password verification of <c>provided_details.phone</c>.
        /// </summary>
        [JsonProperty("require_verification")]
        [STJS.JsonPropertyName("require_verification")]
        public bool RequireVerification { get; set; }
    }
}
