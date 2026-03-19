// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        /// <summary>
        /// An email to contact you with if a copy of the mandate is requested, required if
        /// <c>type</c> is <c>offline</c>.
        /// </summary>
        [JsonProperty("contact_email")]
        [STJS.JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }
    }
}
