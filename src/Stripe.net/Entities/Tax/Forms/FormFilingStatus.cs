// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FormFilingStatus : StripeEntity<FormFilingStatus>
    {
        /// <summary>
        /// Time when the filing status was updated.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public FormFilingStatusJurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// The current status of the filed form.
        /// One of: <c>accepted</c>, <c>filed</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
