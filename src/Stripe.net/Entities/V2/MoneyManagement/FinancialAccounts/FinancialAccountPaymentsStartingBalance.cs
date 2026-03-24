// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountPaymentsStartingBalance : StripeEntity<FinancialAccountPaymentsStartingBalance>
    {
        /// <summary>
        /// When the balance was projected.
        /// </summary>
        [JsonProperty("at")]
        [STJS.JsonPropertyName("at")]
        public DateTime At { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The available balance at the time when the balance was projected.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public Dictionary<string, V2.Amount> Available { get; set; }
    }
}
