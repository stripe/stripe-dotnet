// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkSubscriptionDataTrialSettingsEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// Indicates how the subscription should change when the trial ends if the user did not
        /// provide a payment method.
        /// One of: <c>cancel</c>, <c>create_invoice</c>, or <c>pause</c>.
        /// </summary>
        [JsonProperty("missing_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("missing_payment_method")]
#endif

        public string MissingPaymentMethod { get; set; }
    }
}
