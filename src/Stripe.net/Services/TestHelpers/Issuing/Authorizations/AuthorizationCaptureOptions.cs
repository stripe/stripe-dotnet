// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the authorization. If not provided, the full amount of the
        /// authorization will be captured. This amount is in the authorization currency and in the
        /// <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("capture_amount")]
        [STJS.JsonPropertyName("capture_amount")]
        public long? CaptureAmount { get; set; }

        /// <summary>
        /// Whether to close the authorization after capture. Defaults to true. Set to false to
        /// enable multi-capture flows.
        /// </summary>
        [JsonProperty("close_authorization")]
        [STJS.JsonPropertyName("close_authorization")]
        public bool? CloseAuthorization { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
        [STJS.JsonPropertyName("purchase_details")]
        public AuthorizationPurchaseDetailsOptions PurchaseDetails { get; set; }
    }
}
