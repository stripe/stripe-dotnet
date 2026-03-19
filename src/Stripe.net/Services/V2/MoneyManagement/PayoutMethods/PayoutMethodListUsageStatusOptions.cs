// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutMethodListUsageStatusOptions : INestedOptions
    {
        /// <summary>
        /// List of payments status to filter by.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public List<string> Payments { get; set; }

        /// <summary>
        /// List of transfers status to filter by.
        /// One of: <c>eligible</c>, <c>invalid</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("transfers")]
        [STJS.JsonPropertyName("transfers")]
        public List<string> Transfers { get; set; }
    }
}
