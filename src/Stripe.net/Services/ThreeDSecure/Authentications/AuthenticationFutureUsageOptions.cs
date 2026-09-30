// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationFutureUsageOptions : INestedOptions
    {
        /// <summary>
        /// Parameters related to an installment payment.
        /// </summary>
        [JsonProperty("installment")]
        [STJS.JsonPropertyName("installment")]
        public AuthenticationFutureUsageInstallmentOptions Installment { get; set; }

        /// <summary>
        /// Parameters related to a recurring payment.
        /// </summary>
        [JsonProperty("recurring")]
        [STJS.JsonPropertyName("recurring")]
        public AuthenticationFutureUsageRecurringOptions Recurring { get; set; }

        /// <summary>
        /// The type of future usage declared for this 3DS Authentication.
        /// One of: <c>card_on_file</c>, <c>installment</c>, or <c>recurring</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
