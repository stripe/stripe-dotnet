// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RequestCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Forwarding Config used when making the forwarded request. The config specifes the
        /// HTTP method, merchant credentials, connection settings, and supported destination URLs.
        /// </summary>
        [JsonProperty("config")]
        public string Config { get; set; }

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
        /// The request body and headers to be sent to the destination endpoint.
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestOptions Request { get; set; }

        /// <summary>
        /// The destination URL for the forwarded request. Must be supported by the config.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
