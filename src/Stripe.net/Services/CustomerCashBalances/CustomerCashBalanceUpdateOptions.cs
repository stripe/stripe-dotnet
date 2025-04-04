// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A hash of settings for this cash balance.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public CustomerCashBalanceSettingsOptions Settings { get; set; }
    }
}
