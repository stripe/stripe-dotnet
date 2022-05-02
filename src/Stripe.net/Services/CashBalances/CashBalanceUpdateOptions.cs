// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CashBalanceUpdateOptions : BaseOptions
    {
        [JsonProperty("settings")]
        public CashBalanceSettingsOptions Settings { get; set; }
    }
}
