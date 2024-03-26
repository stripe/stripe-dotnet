// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsFinancialAccountFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow money movement features.
        /// </summary>
        [JsonProperty("money_movement")]
        public bool? MoneyMovement { get; set; }
    }
}
