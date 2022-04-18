// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Settings controlling the behavior of the customer's cash balance, such as reconciliation
        /// of funds received.
        /// </summary>
        [JsonProperty("settings")]
        public CustomerCashBalanceSettingsOptions Settings { get; set; }
    }
}
