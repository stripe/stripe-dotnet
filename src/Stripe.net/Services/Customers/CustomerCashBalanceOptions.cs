// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Settings controlling the behavior of the customer's cash balance, such as reconciliation
        /// of funds received.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public CustomerCashBalanceSettingsOptions Settings { get; set; }
    }
}
