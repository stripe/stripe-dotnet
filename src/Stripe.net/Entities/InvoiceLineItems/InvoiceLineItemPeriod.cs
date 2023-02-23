// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceLineItemPeriod : StripeEntity<InvoiceLineItemPeriod>
    {
        /// <summary>
        /// The end of the period, which must be greater than or equal to the start. This value is
        /// inclusive.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime End { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start of the period. This value is inclusive.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
