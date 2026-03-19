// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentProcessingCard : StripeEntity<PaymentIntentProcessingCard>
    {
        [JsonProperty("customer_notification")]
        [STJS.JsonPropertyName("customer_notification")]
        public PaymentIntentProcessingCardCustomerNotification CustomerNotification { get; set; }
    }
}
