// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceSettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Settings that apply to the <a href="https://docs.stripe.com/api/balance">Payments
        /// Balance</a>.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public BalanceSettingsPaymentsOptions Payments { get; set; }
    }
}
