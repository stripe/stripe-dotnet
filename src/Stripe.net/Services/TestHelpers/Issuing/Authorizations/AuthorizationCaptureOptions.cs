// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the authorization. If not provided, the full amount of the
        /// authorization will be captured. This amount is in the authorization currency and in the
        /// <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("capture_amount")]
        public long? CaptureAmount { get; set; }

        /// <summary>
        /// Whether to close the authorization after capture. Defaults to true. Set to false to
        /// enable multi-capture flows.
        /// </summary>
        [JsonProperty("close_authorization")]
        public bool? CloseAuthorization { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
        public AuthorizationPurchaseDetailsOptions PurchaseDetails { get; set; }
    }
}
