// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitDisputeDetails : StripeEntity<ReceivedDebitDisputeDetails>
    {
        /// <summary>
        /// The ID of the debit dispute, if one has been created.
        /// </summary>
        [JsonProperty("debit_dispute")]
        [STJS.JsonPropertyName("debit_dispute")]
        public string DebitDispute { get; set; }

        /// <summary>
        /// The time at which the dispute window closes.
        /// </summary>
        [JsonProperty("dispute_window_closes_at")]
        [STJS.JsonPropertyName("dispute_window_closes_at")]
        public DateTime? DisputeWindowClosesAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
