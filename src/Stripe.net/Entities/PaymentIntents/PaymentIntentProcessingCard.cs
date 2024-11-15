// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentProcessingCard : StripeEntity<PaymentIntentProcessingCard>
    {
        [JsonProperty("customer_notification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_notification")]
#endif

        public PaymentIntentProcessingCardCustomerNotification CustomerNotification { get; set; }
    }
}
