// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionHostedOptions : INestedOptions
    {
        /// <summary>
        /// How the user should enter the hosted flow. The values <c>email</c> and <c>url</c> can
        /// only be used if <c>relink_options</c> is provided.
        /// One of: <c>email</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("delivery_method")]
        [STJS.JsonPropertyName("delivery_method")]
        public string DeliveryMethod { get; set; }
    }
}
