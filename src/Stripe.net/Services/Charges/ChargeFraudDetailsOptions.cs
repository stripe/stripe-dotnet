// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargeFraudDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Either <c>safe</c> or <c>fraudulent</c>.
        /// One of: <c>fraudulent</c>, or <c>safe</c>.
        /// </summary>
        [JsonProperty("user_report")]
        [STJS.JsonPropertyName("user_report")]
        public string UserReport { get; set; }
    }
}
