// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodListUsageStatusOptions : INestedOptions
    {
        /// <summary>
        /// List of payments status to filter by.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public List<string> Payments { get; set; }

        /// <summary>
        /// List of transfers status to filter by.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfers")]
#endif
        public List<string> Transfers { get; set; }
    }
}
