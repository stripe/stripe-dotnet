// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FormFilingStatus : StripeEntity<FormFilingStatus>
    {
        /// <summary>
        /// Time when the filing status was updated.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("jurisdiction")]
        public FormFilingStatusJurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// The current status of the filed form.
        /// One of: <c>accepted</c>, <c>filed</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
