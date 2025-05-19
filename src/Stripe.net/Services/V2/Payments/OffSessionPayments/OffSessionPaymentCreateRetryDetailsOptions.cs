// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateRetryDetailsOptions : INestedOptions
    {
        /// <summary>
        /// How you want Stripe to retry the payment.
        /// One of: <c>none</c>, or <c>smart</c>.
        /// </summary>
        [JsonProperty("retry_strategy")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_strategy")]
#endif
        public string RetryStrategy { get; set; }
    }
}
