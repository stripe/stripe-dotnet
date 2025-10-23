// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2MoneyManagementTransactionCreatedEventData : StripeEntity<V2MoneyManagementTransactionCreatedEventData>
    {
        /// <summary>
        /// Id of the v1 Transaction corresponding to this Transaction.
        /// </summary>
        [JsonProperty("v1_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("v1_id")]
#endif
        public string V1Id { get; set; }
    }
}
