// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountAccruedFees : StripeEntity<FinancialAccountAccruedFees>
    {
        /// <summary>
        /// The currencies enabled for fee accrual on this FinancialAccount.
        /// </summary>
        [JsonProperty("currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currencies")]
#endif
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Direction of fee accrual for this FinancialAccount.
        /// One of: <c>payable</c>, or <c>receivable</c>.
        /// </summary>
        [JsonProperty("direction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("direction")]
#endif
        public string Direction { get; set; }
    }
}
