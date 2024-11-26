// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeFraudDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Either <c>safe</c> or <c>fraudulent</c>.
        /// One of: <c>fraudulent</c>, or <c>safe</c>.
        /// </summary>
        [JsonProperty("user_report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_report")]
#endif
        public string UserReport { get; set; }
    }
}
