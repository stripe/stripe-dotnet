// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandateStatusDetails : StripeEntity<InboundTransferMandateStatusDetails>
    {
        /// <summary>
        /// Present when the mandate is in the CANCELED state.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public InboundTransferMandateStatusDetailsCanceled Canceled { get; set; }
    }
}
