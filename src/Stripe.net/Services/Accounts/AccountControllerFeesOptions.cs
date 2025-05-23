// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerFeesOptions : INestedOptions
    {
        /// <summary>
        /// A value indicating the responsible payer of Stripe fees on this account. Defaults to
        /// <c>account</c>. Learn more about <a
        /// href="https://docs.stripe.com/connect/direct-charges-fee-payer-behavior">fee behavior on
        /// connected accounts</a>.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public string Payer { get; set; }
    }
}
