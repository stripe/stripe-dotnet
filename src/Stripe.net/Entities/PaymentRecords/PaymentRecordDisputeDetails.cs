// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordDisputeDetails : StripeEntity<PaymentRecordDisputeDetails>
    {
        /// <summary>
        /// Total amounts reinstated across all disputes, keyed by currency, with each value
        /// containing the total for that currency. Withdrawals are not subtracted from these
        /// totals.
        /// </summary>
        [JsonProperty("reinstated")]
        [STJS.JsonPropertyName("reinstated")]
        public Dictionary<string, PaymentRecordDisputeDetailsReinstated> Reinstated { get; set; }

        /// <summary>
        /// Total amounts withdrawn across all disputes, keyed by currency, with each value
        /// containing the total for that currency. Reinstatements are not subtracted from these
        /// totals.
        /// </summary>
        [JsonProperty("withdrawn")]
        [STJS.JsonPropertyName("withdrawn")]
        public Dictionary<string, PaymentRecordDisputeDetailsWithdrawn> Withdrawn { get; set; }
    }
}
