// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CashBalanceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A hash of settings for this cash balance.
        /// </summary>
        [JsonProperty("settings")]
        public CashBalanceSettingsOptions Settings { get; set; }
    }
}
