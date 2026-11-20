// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordProcessorDetailsStripe : StripeEntity<PaymentRecordProcessorDetailsStripe>
    {
        /// <summary>
        /// Stripe balance transactions associated with this attempt, in no guaranteed order.
        /// References can appear at submission or after success. On a PaymentRecord, these
        /// references follow the latest attempt.
        /// </summary>
        [JsonProperty("derived_balance_transactions")]
        [STJS.JsonPropertyName("derived_balance_transactions")]
        public List<string> DerivedBalanceTransactions { get; set; }
    }
}
