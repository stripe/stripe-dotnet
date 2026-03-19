// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkCustomTextTermsOfServiceAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// Text can be up to 1200 characters in length.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
