// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the authorization. If not provided, the full amount of the
        /// authorization will be captured. This amount is in the authorization currency and in the
        /// <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("capture_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_amount")]
#endif
        public long? CaptureAmount { get; set; }

        /// <summary>
        /// Whether to close the authorization after capture. Defaults to true. Set to false to
        /// enable multi-capture flows.
        /// </summary>
        [JsonProperty("close_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("close_authorization")]
#endif
        public bool? CloseAuthorization { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_details")]
#endif
        public AuthorizationPurchaseDetailsOptions PurchaseDetails { get; set; }
    }
}
