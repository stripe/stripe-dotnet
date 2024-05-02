// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewRechnung : StripeEntity<ConfirmationTokenPaymentMethodPreviewRechnung>
    {
        [JsonProperty("dob")]
        public ConfirmationTokenPaymentMethodPreviewRechnungDob Dob { get; set; }
    }
}
