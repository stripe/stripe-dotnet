// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateStorageDepositInsuranceEligibilityOptions : INestedOptions
    {
        /// <summary>
        /// The bank where funds are stored.
        /// One of: <c>fifth_third</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Currencies eligible for deposit insurance at this bank under this scheme.
        /// </summary>
        [JsonProperty("currencies")]
        [STJS.JsonPropertyName("currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// The deposit insurance scheme.
        /// One of: <c>fdic</c>, or <c>fdic_passthrough</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
