// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionWechatPayDisplayQrCode : StripeEntity<PaymentIntentNextActionWechatPayDisplayQrCode>
    {
        /// <summary>
        /// The data being used to generate QR code.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The base64 image data for a pre-generated QR code.
        /// </summary>
        [JsonProperty("image_data_url")]
        public string ImageDataUrl { get; set; }
    }
}
