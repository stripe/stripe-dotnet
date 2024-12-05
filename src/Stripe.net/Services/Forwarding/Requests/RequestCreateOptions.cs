// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
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
        /// The request body and headers to be sent to the destination endpoint.
        /// </summary>
        [JsonProperty("request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request")]
#endif
        public RequestRequestOptions Request { get; set; }

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
