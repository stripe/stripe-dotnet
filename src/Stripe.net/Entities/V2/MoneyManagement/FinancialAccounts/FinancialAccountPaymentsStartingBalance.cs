// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountPaymentsStartingBalance : StripeEntity<FinancialAccountPaymentsStartingBalance>
    {
        /// <summary>
        /// When the balance was projected.
        /// </summary>
        [JsonProperty("at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("at")]
#endif
        public DateTime At { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The available balance at the time when the balance was projected.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public Dictionary<string, FinancialAccountPaymentsStartingBalanceAvailable> Available { get; set; }
    }
}
