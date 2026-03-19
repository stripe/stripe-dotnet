// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountAccruedFees : StripeEntity<FinancialAccountAccruedFees>
    {
        /// <summary>
        /// The currencies enabled for fee accrual on this FinancialAccount.
        /// </summary>
        [JsonProperty("currencies")]
        [STJS.JsonPropertyName("currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Direction of fee accrual for this FinancialAccount.
        /// One of: <c>payable</c>, or <c>receivable</c>.
        /// </summary>
        [JsonProperty("direction")]
        [STJS.JsonPropertyName("direction")]
        public string Direction { get; set; }
    }
}
