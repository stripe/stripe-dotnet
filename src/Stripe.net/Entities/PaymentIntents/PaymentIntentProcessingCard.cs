// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentProcessingCard : StripeEntity<PaymentIntentProcessingCard>
    {
        [JsonProperty("customer_notification")]
        public PaymentIntentProcessingCardCustomerNotification CustomerNotification { get; set; }
    }
}
