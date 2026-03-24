// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetails : StripeEntity<ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
        [STJS.JsonPropertyName("blocked")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
