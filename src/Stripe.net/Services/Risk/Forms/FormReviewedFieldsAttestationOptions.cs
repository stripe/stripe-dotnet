// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormReviewedFieldsAttestationOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp when the connected account attested to these fields.
        /// </summary>
        [JsonProperty("attested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("attested_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AttestedAt { get; set; }

        /// <summary>
        /// Account field paths in the currently accepted v2 Accounts API format, for example
        /// <c>defaults.profile.product_description</c>.
        /// </summary>
        [JsonProperty("fields")]
        [STJS.JsonPropertyName("fields")]
        public List<string> Fields { get; set; }
    }
}
