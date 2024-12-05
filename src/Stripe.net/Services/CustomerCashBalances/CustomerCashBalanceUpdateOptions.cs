// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A hash of settings for this cash balance.
        /// </summary>
        [JsonProperty("settings")]
        public CustomerCashBalanceSettingsOptions Settings { get; set; }
    }
}
