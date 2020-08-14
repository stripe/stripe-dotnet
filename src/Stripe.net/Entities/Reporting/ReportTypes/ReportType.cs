namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportType : StripeEntity<ReportType>, IHasId, IHasObject
    {
        /// <summary>
        /// The <a href="https://stripe.com/docs/reporting/statements/api#available-report-types">ID
        /// of the Report Type</a>, such as <c>balance.summary.1</c>.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Most recent time for which this Report Type is available. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("data_available_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataAvailableEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Earliest time for which this Report Type is available. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("data_available_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataAvailableStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of column names that are included by default when this Report Type gets run. (If
        /// the Report Type doesn't support the <c>columns</c> parameter, this will be null.).
        /// </summary>
        [JsonProperty("default_columns")]
        public List<string> DefaultColumns { get; set; }

        /// <summary>
        /// Human-readable name of the Report Type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// When this Report Type was latest updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Version of the Report Type. Different versions report with the same ID will have the
        /// same purpose, but may take different run parameters or have different result schemas.
        /// </summary>
        [JsonProperty("version")]
        public long Version { get; set; }
    }
}
