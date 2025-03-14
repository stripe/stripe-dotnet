// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewRechnung : StripeEntity<ConfirmationTokenPaymentMethodPreviewRechnung>
    {
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public ConfirmationTokenPaymentMethodPreviewRechnungDob Dob { get; set; }
    }
}
