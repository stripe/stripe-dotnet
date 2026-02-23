// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionHostedOptions : INestedOptions
    {
        /// <summary>
        /// How the user should enter the hosted flow. The values <c>email</c> and <c>url</c> can
        /// only be used if <c>relink_options</c> is provided.
        /// One of: <c>email</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("delivery_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_method")]
#endif
        public string DeliveryMethod { get; set; }
    }
}
