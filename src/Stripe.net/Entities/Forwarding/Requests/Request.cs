// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Instructs Stripe to make a request on your behalf using the destination URL and HTTP
    /// method in the config. A config is set up for each destination URL by Stripe at the time
    /// of onboarding. Stripe verifies requests with your credentials in the config, and injects
    /// card details from the payment_method into the request.
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
    public class Request : StripeEntity<Request>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The Forwarding Config used when making the forwarded request. The config specifes the
        /// HTTP method, merchant credentials, connection settings, and supported destination URLs.
        /// </summary>
        [JsonProperty("config")]
        public string Config { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The PaymentMethod to insert into the forwarded request. Forwarding previously consumed
        /// PaymentMethods is allowed.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The field kinds to be replaced in the forwarded request.
        /// One of: <c>card_cvc</c>, <c>card_expiry</c>, <c>card_number</c>, or
        /// <c>cardholder_name</c>.
        /// </summary>
        [JsonProperty("replacements")]
        public List<string> Replacements { get; set; }

        /// <summary>
        /// Context about the request from Stripe's servers to the destination endpoint.
        /// </summary>
        [JsonProperty("request_context")]
        public RequestRequestContext RequestContext { get; set; }

        /// <summary>
        /// The request that was sent to the destination endpoint. We redact any sensitive fields.
        /// </summary>
        [JsonProperty("request_details")]
        public RequestRequestDetails RequestDetails { get; set; }

        /// <summary>
        /// The response that the destination endpoint returned to us. We redact any sensitive
        /// fields.
        /// </summary>
        [JsonProperty("response_details")]
        public RequestResponseDetails ResponseDetails { get; set; }

        /// <summary>
        /// The destination URL for the forwarded request. Must be supported by the config.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
