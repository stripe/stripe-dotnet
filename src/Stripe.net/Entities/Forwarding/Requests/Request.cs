// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Instructs Stripe to make a request on your behalf using the destination URL. The
    /// destination URL is activated by Stripe at the time of onboarding. Stripe verifies
    /// requests with your credentials provided during onboarding, and injects card details from
    /// the payment_method into the request.
    ///
    /// Stripe redacts all sensitive fields and headers, including authentication credentials
    /// and card numbers, before storing the request and response data in the forwarding Request
    /// object, which are subject to a 30-day retention period.
    ///
    /// You can provide a Stripe idempotency key to make sure that requests with the same key
    /// result in only one outbound request. The Stripe idempotency key provided should be
    /// unique and different from any idempotency keys provided on the underlying third-party
    /// request.
    ///
    /// Forwarding Requests are synchronous requests that return a response or time out
    /// according to Stripe’s limits.
    ///
    /// Related guide: <a href="https://docs.stripe.com/payments/forwarding">Forward card
    /// details to third-party API endpoints</a>.
    /// </summary>
    public class Request : StripeEntity<Request>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The PaymentMethod to insert into the forwarded request. Forwarding previously consumed
        /// PaymentMethods is allowed.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif

        public string PaymentMethod { get; set; }

        /// <summary>
        /// The field kinds to be replaced in the forwarded request.
        /// One of: <c>card_cvc</c>, <c>card_expiry</c>, <c>card_number</c>, or
        /// <c>cardholder_name</c>.
        /// </summary>
        [JsonProperty("replacements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacements")]
#endif

        public List<string> Replacements { get; set; }

        /// <summary>
        /// Context about the request from Stripe's servers to the destination endpoint.
        /// </summary>
        [JsonProperty("request_context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_context")]
#endif

        public RequestRequestContext RequestContext { get; set; }

        /// <summary>
        /// The request that was sent to the destination endpoint. We redact any sensitive fields.
        /// </summary>
        [JsonProperty("request_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_details")]
#endif

        public RequestRequestDetails RequestDetails { get; set; }

        /// <summary>
        /// The response that the destination endpoint returned to us. We redact any sensitive
        /// fields.
        /// </summary>
        [JsonProperty("response_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("response_details")]
#endif

        public RequestResponseDetails ResponseDetails { get; set; }

        /// <summary>
        /// The destination URL for the forwarded request. Must be supported by the config.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif

        public string Url { get; set; }
    }
}
