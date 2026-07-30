// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitMandateStatusDetails : StripeEntity<ReceivedDebitMandateStatusDetails>
    {
        /// <summary>
        /// If the mandate is canceled, this field provides more details on the cancellation reason.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public ReceivedDebitMandateStatusDetailsCanceled Canceled { get; set; }
    }
}
