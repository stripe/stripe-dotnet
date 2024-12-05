// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodRechnung : StripeEntity<PaymentMethodRechnung>
    {
        [JsonProperty("dob")]
        public PaymentMethodRechnungDob Dob { get; set; }
    }
}
