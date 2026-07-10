namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class StripeError : StripeEntity<StripeError>
    {
        // errorFields: The beginning of the section generated from our OpenAPI spec

        /// <summary>
        /// For card errors resulting from a card issuer decline, a short string indicating <a
        /// href="https://docs.stripe.com/declines#retrying-issuer-declines">how to proceed with an
        /// error</a> if they provide one.
        /// </summary>
        [JsonProperty("advice_code")]
        [STJS.JsonPropertyName("advice_code")]
        public string AdviceCode { get; set; }

        /// <summary>
        /// For card errors, the ID of the failed charge.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// For some errors that could be handled programmatically, a short string indicating the <a
        /// href="https://docs.stripe.com/error-codes">error code</a> reported.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// For card errors resulting from a card issuer decline, a short string indicating the <a
        /// href="https://docs.stripe.com/declines#issuer-declines">card issuer's reason for the
        /// decline</a> if they provide one.
        /// </summary>
        [JsonProperty("decline_code")]
        [STJS.JsonPropertyName("decline_code")]
        public string DeclineCode { get; set; }

        /// <summary>
        /// A URL to more information about the <a href="https://docs.stripe.com/error-codes">error
        /// code</a> reported.
        /// </summary>
        [JsonProperty("doc_url")]
        [STJS.JsonPropertyName("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error. For card errors, these
        /// messages can be shown to your users.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// For card errors resulting from a card issuer decline, a 2 digit code which indicates the
        /// advice given to merchant by the card network on how to proceed with an error.
        /// </summary>
        [JsonProperty("network_advice_code")]
        [STJS.JsonPropertyName("network_advice_code")]
        public string NetworkAdviceCode { get; set; }

        /// <summary>
        /// For payments declined by the network, an alphanumeric code which indicates the reason
        /// the payment failed.
        /// </summary>
        [JsonProperty("network_decline_code")]
        [STJS.JsonPropertyName("network_decline_code")]
        public string NetworkDeclineCode { get; set; }

        /// <summary>
        /// If the error is parameter-specific, the parameter related to the error. For example, you
        /// can use this to display a message near the correct form field.
        /// </summary>
        [JsonProperty("param")]
        [STJS.JsonPropertyName("param")]
        public string Param { get; set; }

        /// <summary>
        /// The PaymentIntent object for errors returned on a request involving a PaymentIntent.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public PaymentIntent PaymentIntent { get; set; }

        /// <summary>
        /// The PaymentMethod object for errors returned on a request involving a PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// If the error is specific to the type of payment method, the payment method type that had
        /// a problem. This field is only populated for invoice-related errors.
        /// </summary>
        [JsonProperty("payment_method_type")]
        [STJS.JsonPropertyName("payment_method_type")]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// A URL to the request log entry in your dashboard.
        /// </summary>
        [JsonProperty("request_log_url")]
        [STJS.JsonPropertyName("request_log_url")]
        public string RequestLogUrl { get; set; }

        /// <summary>
        /// The SetupIntent object for errors returned on a request involving a SetupIntent.
        /// </summary>
        [JsonProperty("setup_intent")]
        [STJS.JsonPropertyName("setup_intent")]
        public SetupIntent SetupIntent { get; set; }

        /// <summary>
        /// The PaymentSource object for errors returned on a request involving a PaymentSource.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
        [STJS.JsonPropertyName("source")]
        public IPaymentSource Source { get; set; }

        /// <summary>
        /// The type of error returned. One of <c>api_error</c>, <c>card_error</c>,
        /// <c>idempotency_error</c>, or <c>invalid_request_error</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The user message associated with the error.
        /// </summary>
        [JsonProperty("user_message")]
        [STJS.JsonPropertyName("user_message")]
        public string UserMessage { get; set; }

        // errorFields: The end of the section generated from our OpenAPI spec

        /*
         * For OAuth Errors:
         */

        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        [STJS.JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }
    }
}
