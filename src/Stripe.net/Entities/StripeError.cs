namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class StripeError : StripeEntity<StripeError>
    {
        /*
         * For regular API errors:
         */

        /// <summary>For card errors, the ID of the failed charge.</summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// For some errors that could be handled programmatically, a short string indicating the
        /// <a href="https://stripe.com/docs/error-codes">error code</a> reported.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// For card errors resulting from a card issuer decline, a short string indicating the
        /// <a href="https://stripe.com//docs/declines#issuer-declines">card issuer's reason for the
        /// decline</a>.
        /// </summary>
        [JsonProperty("decline_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("decline_code")]
#endif
        public string DeclineCode { get; set; }

        /// <summary>
        /// A URL to more information about the <a href="https://stripe.com/docs/error-codes">error
        /// code</a> reported.
        /// </summary>
        [JsonProperty("doc_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("doc_url")]
#endif
        public string DocUrl { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error. For card errors, these
        /// messages can be shown to your users.
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// If the error is parameter-specific, the parameter related to the error. For example,
        /// you can use this to display a message near the correct form field.
        /// </summary>
        [JsonProperty("param")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("param")]
#endif
        public string Param { get; set; }

        /// <summary>
        /// The <see cref="Stripe.PaymentIntent"/> object for errors returned on a request
        /// involving a <see cref="Stripe.PaymentIntent"/>.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public PaymentIntent PaymentIntent { get; set; }

        /// <summary>
        /// The <see cref="Stripe.PaymentMethod"/> object for errors returned on a request
        /// involving a <see cref="Stripe.PaymentMethod"/>.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// If the error is specific to the type of payment method, the payment method type that had
        /// a problem. This field is only populated for invoice-related errors.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// A URL to the request log entry in your dashboard.
        /// </summary>
        [JsonProperty("request_log_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_log_url")]
#endif
        public string RequestLogUrl { get; set; }

        /// <summary>
        /// The <see cref="Stripe.SetupIntent"/> object for errors returned on a request
        /// involving a <see cref="Stripe.SetupIntent"/>.
        /// </summary>
        [JsonProperty("setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
#endif
        public SetupIntent SetupIntent { get; set; }

        /// <summary>
        /// The source object for errors returned on a request involving a source.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
#endif
        public IPaymentSource Source { get; set; }

        /// <summary>
        /// The type of error returned. One of <c>api_error</c>, <c>card_error</c>,
        /// <c>idempotency_error</c>, or <c>invalid_request_error</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /*
         * For OAuth Errors:
         */

        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public string Error { get; set; }

        [JsonProperty("error_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_description")]
#endif
        public string ErrorDescription { get; set; }
    }
}
