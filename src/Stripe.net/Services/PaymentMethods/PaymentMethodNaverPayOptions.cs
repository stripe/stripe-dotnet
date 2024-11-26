// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodNaverPayOptions : INestedOptions
    {
        /// <summary>
        /// Whether to use Naver Pay points or a card to fund this transaction. If not provided,
        /// this defaults to <c>card</c>.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public string Funding { get; set; }
    }
}
