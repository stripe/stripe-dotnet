// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodDataSofortOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// One of: <c>AT</c>, <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>IT</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }
    }
}
