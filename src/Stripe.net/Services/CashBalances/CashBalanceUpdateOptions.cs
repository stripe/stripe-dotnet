namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use CustomerCashBalanceUpdateOptions instead.")]
    public class CashBalanceUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A hash of settings for this cash balance.
        /// </summary>
        [JsonProperty("settings")]
        public CashBalanceSettingsOptions Settings { get; set; }
    }
}
