// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class SetupIntentPaymentMethodOptionsCardMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// One of <c>fixed</c> or <c>maximum</c>. If <c>fixed</c>, the <c>amount</c> param refers
        /// to the exact amount to be charged in future payments. If <c>maximum</c>, the amount
        /// charged can be up to the value passed for the <c>amount</c> param.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// Currency in which future payments will be charged. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A description of the mandate or subscription that is meant to be displayed to the
        /// customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// End date of the mandate or subscription. If not provided, the mandate will be active
        /// until canceled. If provided, end date should be after start date.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Specifies payment frequency. One of <c>day</c>, <c>week</c>, <c>month</c>, <c>year</c>,
        /// or <c>sporadic</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>sporadic</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between payments. For example, <c>interval=month</c> and
        /// <c>interval_count=3</c> indicates one payment every three months. Maximum of one year
        /// interval allowed (1 year, 12 months, or 52 weeks). This parameter is optional when
        /// <c>interval=sporadic</c>.
        /// </summary>
        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Unique identifier for the mandate or subscription.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Start date of the mandate or subscription. Start date should not be lesser than
        /// yesterday.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Specifies the type of mandates supported. Possible values are <c>india</c>.
        /// </summary>
        [JsonProperty("supported_types")]
        public List<string> SupportedTypes { get; set; }
    }
}
