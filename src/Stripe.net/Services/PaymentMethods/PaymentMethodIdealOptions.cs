// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodIdealOptions : INestedOptions
    {
        /// <summary>
        /// The customer's bank. Only use this parameter for existing customers. Don't use it for
        /// new customers.
        /// One of: <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>, <c>buut</c>,
        /// <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>, <c>n26</c>, <c>nn</c>,
        /// <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>, <c>triodos_bank</c>,
        /// <c>van_lanschot</c>, or <c>yoursafe</c>.
        /// </summary>
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }
    }
}
