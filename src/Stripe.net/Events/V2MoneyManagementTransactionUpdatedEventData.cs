// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2MoneyManagementTransactionUpdatedEventData : StripeEntity<V2MoneyManagementTransactionUpdatedEventData>
    {
        /// <summary>
        /// Id of the v1 Treasury Transaction corresponding to this Transaction.
        /// </summary>
        [JsonProperty("treasury_transaction")]
        [STJS.JsonPropertyName("treasury_transaction")]
        public string TreasuryTransaction { get; set; }
    }
}
