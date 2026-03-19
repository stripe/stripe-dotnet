// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The PaymentMethod to insert into the forwarded request. Forwarding previously consumed
        /// PaymentMethods is allowed.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The field kinds to be replaced in the forwarded request.
        /// One of: <c>card_cvc</c>, <c>card_expiry</c>, <c>card_number</c>, <c>cardholder_name</c>,
        /// or <c>request_signature</c>.
        /// </summary>
        [JsonProperty("replacements")]
        [STJS.JsonPropertyName("replacements")]
        public List<string> Replacements { get; set; }

        /// <summary>
        /// The request body and headers to be sent to the destination endpoint.
        /// </summary>
        [JsonProperty("request")]
        [STJS.JsonPropertyName("request")]
        public RequestRequestOptions Request { get; set; }

        /// <summary>
        /// The destination URL for the forwarded request. Must be supported by the config.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
