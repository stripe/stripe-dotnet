// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormReviewedFieldsAttestation : StripeEntity<FormReviewedFieldsAttestation>
    {
        /// <summary>
        /// Time when the connected account attested to these fields, measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("attested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("attested_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime AttestedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Account field paths covered by this attestation. These are currently returned in v2
        /// Accounts API format, such as <c>defaults.profile.product_description</c>.
        /// </summary>
        [JsonProperty("fields")]
        [STJS.JsonPropertyName("fields")]
        public List<string> Fields { get; set; }
    }
}
