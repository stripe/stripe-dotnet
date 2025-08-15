// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountGetOptions : BaseOptions
    {
        /// <summary>
        /// Closed Enum. Additional fields to include in the response. Currently supports
        /// <c>configuration.recipient_data</c>, <c>legal_entity_data</c>, <c>requirements</c>, and
        /// <c>supportable_features.recipient_data</c>.
        /// One of: <c>configuration.recipient_data</c>, <c>legal_entity_data</c>,
        /// <c>requirements</c>, or <c>supportable_features.recipient_data</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }
    }
}
