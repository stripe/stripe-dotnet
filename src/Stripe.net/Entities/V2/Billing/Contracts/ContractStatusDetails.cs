// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractStatusDetails : StripeEntity<ContractStatusDetails>
    {
        /// <summary>
        /// Details of the active contract status.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public ContractStatusDetailsActive Active { get; set; }

        /// <summary>
        /// Details of the canceled contract status.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public ContractStatusDetailsCanceled Canceled { get; set; }
    }
}
