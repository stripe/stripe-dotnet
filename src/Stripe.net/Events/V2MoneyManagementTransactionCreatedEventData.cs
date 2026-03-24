// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2MoneyManagementTransactionCreatedEventData : StripeEntity<V2MoneyManagementTransactionCreatedEventData>
    {
        /// <summary>
        /// Id of the v1 Transaction corresponding to this Transaction.
        /// </summary>
        [JsonProperty("v1_id")]
        [STJS.JsonPropertyName("v1_id")]
        public string V1Id { get; set; }
    }
}
