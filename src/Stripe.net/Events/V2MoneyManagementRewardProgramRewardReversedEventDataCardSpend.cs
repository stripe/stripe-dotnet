// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementRewardProgramRewardReversedEventDataCardSpend : StripeEntity<V2MoneyManagementRewardProgramRewardReversedEventDataCardSpend>
    {
        /// <summary>
        /// The Issuing cardholder whose spend earned the original reward.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// The Issuing transaction that reversed the reward. Present when the reversal is
        /// calculated from a single Issuing transaction.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        [STJS.JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// The Issuing transaction that earned the original reward. Present when the reversal is
        /// calculated from a single Issuing transaction and Stripe can associate it with the
        /// original transaction.
        /// </summary>
        [JsonProperty("original_transaction")]
        [STJS.JsonPropertyName("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
