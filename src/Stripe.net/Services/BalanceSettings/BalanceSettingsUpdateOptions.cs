// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceSettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Settings that apply to the <a href="https://docs.stripe.com/api/balance">Payments
        /// Balance</a>.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public BalanceSettingsPaymentsOptions Payments { get; set; }
    }
}
